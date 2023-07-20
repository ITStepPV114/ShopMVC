using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopMVC.Models;

namespace ShopMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ShopMVCDbContext _context;
        public ProductController(ShopMVCDbContext context)
        {
            _context =context ;
          }

        public IActionResult Index()
        {
            //TODO: dbcontext
            var products = _context.Products.Include(p => p.Category).ToList();
            return View(products);
        }
        public IActionResult Details(int? id) { 
            //find in DataBase
            var product = _context.Products.Include(p=>p.Category).FirstOrDefault(p=>p.Id==id);
            if (product == null) return NotFound();
            return View(product);
        }

        public IActionResult Delete(int? id)
        {
            //find in DataBase
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
               
            }
            return RedirectToAction(nameof(Index), "Home");
           // return Redirect("~/Home/Index");
           
            
        }
    }
}
