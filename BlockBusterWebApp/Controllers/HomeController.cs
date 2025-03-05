using System.Diagnostics;
using BlockBusterWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using BlockBuster;

namespace BlockBusterWebApp.Controllers
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

        //week 6
        public IActionResult Colors()
        {
            string[] colors = { "Red", "Blue", "Yellow" };
            ViewBag.Colors = colors;
            return View();
        }

        public IActionResult Cities()
        {
            string[] cities = { "Miami, FL", "Barcelona, Spain", "London, England", "Rome, Italy", "New York, NY" };
            ViewBag.Cities = cities;
            return View();
        }

        public IActionResult Hobbies()
        {
            string[] hobbies = { "Skiing and Snowboarding", "Mountain Biking", "Playing Video Games", "Watching Youtube/TV" };
            ViewBag.Hobbies = hobbies;
            return View();
        }

        //week 7
        public IActionResult Movies()
        {
            var movieList = BlockBusterBasicFunctions.GetAllMoviesFull();
            return View(movieList);
        }

    }
}
