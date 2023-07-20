using Microsoft.AspNetCore.Mvc;
using ShopMVC.Helper;
using ShopMVC.Models;

namespace ShopMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly List<ShopMVC.Models.Product> _products;
        public ProductController()
        {
            _products = SeedData.Products;
          }

        public IActionResult Index()
        {
            //TODO: dbcontext
            return View(_products);
        }
        public IActionResult Details(int? id) { 
            //find in DataBase
            var product = _products.FirstOrDefault(p=>p.Id==id);
            if (product == null) return NotFound();
            return View(product);
        }

        public IActionResult Delete(int? id)
        {
            //find in DataBase
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
               
            }
            return View("Index", _products);
        }
    }
}
