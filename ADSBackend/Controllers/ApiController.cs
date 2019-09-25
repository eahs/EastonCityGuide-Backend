using ADSBackend.Models.ApiModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSBackend.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class ApiController : Controller
    {
        private readonly Services.Configuration Configuration;
        private readonly Services.Cache _cache;

        public ApiController(Services.Configuration configuration, Services.Cache cache)
        {
            Configuration = configuration;
            _cache = cache;
        }

        // GET: api/News
        [HttpGet("News")]
        public async Task<List<NewsFeedItem>> GetNewsFeed()
        {
            var newsUrl = new Uri("https://www.eastonsd.org/apps/news/news_rss.jsp");

            string sourceUrl = newsUrl.GetLeftPart(UriPartial.Authority);
            string endpoint = newsUrl.PathAndQuery;

            Task<List<NewsFeedItem>> fetchNewsFromSource() => Util.RSS.GetNewsFeed(sourceUrl, endpoint);

            var feedItems = await _cache.GetAsync("RSS", fetchNewsFromSource, TimeSpan.FromMinutes(5));
            return feedItems.OrderByDescending(x => x.PublishDate).ToList();
        }

        // GET: api/Config
        [HttpGet("Config")]
        public ConfigResponse GetConfig()
        {
            // TODO: extend this object to include some configuration items
            return new ConfigResponse();
        }
    }
}