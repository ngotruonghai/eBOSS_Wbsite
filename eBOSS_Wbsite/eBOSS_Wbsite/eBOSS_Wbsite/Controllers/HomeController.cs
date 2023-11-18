using eBOSS_Wbsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eBOSS_Wbsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult HandleForm(string submitButton)
        {
            if (submitButton == "submit")
            {
                // Code to handle the submit button click
            }
            else if (submitButton == "reset")
            {
                // Code to handle the reset button click or perform a different action
            }

            // Redirect or return a view as needed
            return View("Privacy");
        }
    }
}