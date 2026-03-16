using System.Diagnostics;
using GIT_Practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace GIT_Practice.Controllers
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
            Console.WriteLine("loaded this ");
            return View();
        }
          

        public IActionResult About()
        {
            return View();
        }
        public IActionResult BookRide() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
