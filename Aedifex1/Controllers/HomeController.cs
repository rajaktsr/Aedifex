using System.Diagnostics;
using Aedifex1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aedifex1.Controllers
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

        public IActionResult Products()
        {
            var products = new List<Product>
            {
                new Product { Image = "/assets/catalog1.jpg", Name = "Product 1" },
                new Product { Image = "/assets/catalog2.jpg", Name = "Product 2" },
                new Product { Image = "/assets/catalog3.jpg", Name = "Product 3" },
                new Product { Image = "/assets/catalog4.jpg", Name = "Product 4" },
                new Product { Image = "/assets/catalog5.jpg", Name = "Product 5" },
                new Product { Image = "/assets/catalog6.jpg", Name = "Product 6" },
                new Product { Image = "/assets/catalog7.jpg", Name = "Product 7" },

             
                // Tambahkan lebih banyak produk jika perlu
            };

            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
