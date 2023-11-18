using Microsoft.AspNetCore.Mvc;

namespace eBOSS_WebSite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult component()
        {
            return PartialView();
        }

        public IActionResult component2()
        {
            return PartialView();
        }
    }
}
