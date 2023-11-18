using eBOSS_Wbsite.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace eBOSS_WebSite.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

        public IActionResult Details(string slug)
        {	
			if (slug == null)
			{
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
            return View();
        }
    }
}
