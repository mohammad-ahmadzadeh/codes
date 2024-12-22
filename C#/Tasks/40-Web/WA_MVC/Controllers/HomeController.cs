using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WA_MVC.Data;
using WA_MVC.Models;

namespace WA_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            DbContext db = new DbContext();
            DataTable dt = db.GetAll();
            return View(dt);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contactus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contactus(Book book)
        {
            if (ModelState.IsValid)
            {
                DbContext dbContext = new DbContext();
                dbContext.Add(book);
            }
            return View(book);
        }
        public IActionResult Aboutus()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
