using System;
using eBOSS_WebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace eBOSS_WebSite.ViewComponents
{

    public class ButtonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ButtonComponentModel model)
        {
            return View("ButtonViewComponent", model);
        }
    }
}
