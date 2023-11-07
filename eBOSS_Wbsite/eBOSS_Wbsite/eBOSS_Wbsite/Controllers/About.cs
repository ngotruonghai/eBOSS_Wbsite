using Microsoft.AspNetCore.Mvc;

namespace eBOSS_WebSite.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
