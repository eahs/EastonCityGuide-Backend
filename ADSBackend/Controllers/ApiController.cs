using ADSBackend.Data;
using ADSBackend.Models;
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
        private readonly ApplicationDbContext _context;

        public ApiController(Services.Configuration configuration, Services.Cache cache)
        {
            Configuration = configuration;
            _cache = cache;
        }

        // GET: api/Locations
        [HttpGet("Locations")]
        public async Task<List<Locations>> GetLocations()
        {

            var locations = await _context.Locations.ToListAsync();

            return locations;
            /*
            if (await IsAuthorized() == null)
                return new List<Officer>();

            if (level == null)
                return await _context.Officer.OrderBy(x => x.Order).ToListAsync();

            return await _context.Officer.Where(o => o.Level == level).OrderBy(x => x.Order).ToListAsync();
            */
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