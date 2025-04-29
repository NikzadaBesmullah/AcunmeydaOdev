using System.Diagnostics;
using eTicaretMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTicaretMvc.Controllers
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
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Ýphone", Price = 99999.99m, ImageUrl = "iphone.jpg" },
                new Product { Id = 2, Name = "Asus", Price = 149000.99m, ImageUrl = "pc.jpg" },
                new Product { Id = 3, Name = "Airpods", Price = 1990.99m, ImageUrl = "airpoods.jpg" },
                new Product { Id = 4, Name = "Camera", Price = 89000.99m, ImageUrl = "camera.jpg" },
                new Product { Id = 5, Name = "Keyboard & Mouse", Price = 1290.99m, ImageUrl = "keyboard.jpg" },
                new Product { Id = 6, Name = "Tablet", Price = 17900.99m, ImageUrl = "tablet.jpg" }
            };

            return View(products);
        }
    }

       
    
}
