using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace WebApplication1.Controlleres.Home
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() => Ok("All products");

        [HttpGet]
        public IActionResult Aboutus()
        {
            ViewData["Message"] = "Your application description page.";
            //var model = new { Name = "John Doe" };
            return View("About", ViewData);
        }
    }
}
