// Views/ViewComponents/ProductItem/Default.cshtml.cs
using eBOSS_WebSite.Models;
using Microsoft.AspNetCore.Mvc;

public class BlogItemViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(BlogItemViewModel model)
    {
        return View(model);
    }
}
