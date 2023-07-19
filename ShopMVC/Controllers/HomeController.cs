using Microsoft.AspNetCore.Mvc;
using ShopMVC.Helper;
using ShopMVC.Models;
using System.Diagnostics;

namespace ShopMVC.Controllers
{
    //[Controller]
    //public class Home
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<Product> _products;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _products = SeedData.Products;
        }

        //ViewData
        //ViewBag
        //Mode view
        // 
        public IActionResult Index(string name)
        {

            ViewData["Message"] = " is developing...";
            ViewBag.Users = new List<string> { "Admin", "Author", "Guest" };
            return View(_products);

        }

        //public string Index(string name="Guest")
        //{
        //   return $"Hello, {name}";
        //}


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
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