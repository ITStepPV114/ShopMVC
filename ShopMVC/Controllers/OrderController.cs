using Microsoft.AspNetCore.Mvc;

namespace ShopMVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
