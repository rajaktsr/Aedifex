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
        new Product {Id = 1,  Image = "/assets/catalog1.jpg", Name = "", Category = "Varsity Jacket" },
        new Product {Id = 2,  Image = "/assets/catalog2.jpg", Name = "", Category = "Varsity Jacket" },
        new Product {Id = 3,  Image = "/assets/catalog3.jpg", Name = "", Category = "Varsity Jacket" },
        new Product {Id = 4,  Image = "/assets/catalog4.jpg", Name = "", Category = "Varsity Jacket" },
        new Product {Id = 5,  Image = "/assets/catalog5.jpg", Name = "", Category = "Varsity Jacket" },
        new Product {Id = 6,  Image = "/assets/catalog6.jpg", Name = "", Category = "Varsity Jacket" },
        new Product {Id = 7,  Image = "/assets/catalog7.jpg", Name = "", Category = "Varsity Jacket" },
        new Product {Id = 8,  Image = "/assets/catalog8.jpg", Name = "", Category = "Work Jacket" },
        new Product {Id = 9,  Image = "/assets/catalog9.jpg", Name = "", Category = "Work Jacket" },
        new Product {Id = 10, Image = "/assets/catalog10.jpg", Name = "", Category = "Work Jacket" },
        new Product {Id = 11, Image = "/assets/catalog11.jpg", Name = "", Category = "Work Jacket" },
        new Product {Id = 12, Image = "/assets/catalog12.jpg", Name = "", Category = "Work Jacket" },
        new Product {Id = 13, Image = "/assets/catalog13.jpg", Name = "", Category = "Work Jacket" },
        new Product {Id = 14, Image = "/assets/catalog14.jpg", Name = "", Category = "Work Shirt" },
        new Product {Id = 15, Image = "/assets/catalog15.jpg", Name = "", Category = "Hoodie & Crewneck" },
        new Product {Id = 16, Image = "/assets/catalog16.jpg", Name = "", Category = "Hoodie & Crewneck" },
        new Product {Id = 17, Image = "/assets/catalog17.jpg", Name = "", Category = "Hoodie & Crewneck" },
        new Product {Id = 18, Image = "/assets/catalog18.jpg", Name = "", Category = "Hoodie & Crewneck" },
        new Product {Id = 19, Image = "/assets/catalog19.jpg", Name = "", Category = "Coach Jacket" },
        new Product {Id = 20, Image = "/assets/catalog20.jpg", Name = "", Category = "Coach Jacket" },
        new Product {Id = 21, Image = "/assets/catalog21.jpg", Name = "", Category = "Coach Jacket" },
        new Product {Id = 22, Image = "/assets/catalog22.jpg", Name = "", Category = "Coach Jacket" },
        new Product {Id = 23, Image = "/assets/catalog23.jpg", Name = "", Category = "Coach Jacket" },
        new Product {Id = 24, Image = "/assets/catalog24.jpg", Name = "", Category = "T-Shirt" },
        new Product {Id = 25, Image = "/assets/catalog25.jpg", Name = "", Category = "T-Shirt" },


        // Tambahkan lebih banyak produk jika diperlukan
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
