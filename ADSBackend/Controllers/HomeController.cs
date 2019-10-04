using Microsoft.AspNetCore.Mvc;

namespace ADSBackend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
