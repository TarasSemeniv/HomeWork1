using HomeWork1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HomeWork1.Controllers
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
        public IActionResult Product()
        {
            var product = new Product
            {
                Name = "Gigabyte G6X 9KG",
                Price = 42000,
                Category = new Category
                {
                    Name = "Laptops",
                    Description = "",
                    Discount = 5
                }
            };
            ViewBag.Description = "Balanced gaming laptops from the Gigabyte Gaming line of 2024";
            ViewData["DateOfManufacture"] = DateTime.Now;
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
