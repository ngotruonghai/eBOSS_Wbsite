using Microsoft.AspNetCore.Mvc;

namespace eBOSS_WebSite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
