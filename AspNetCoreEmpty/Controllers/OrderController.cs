using AspNetCoreEmpty.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEmpty.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(
            AppDbContext appDbContext,
            ShoppingCart shoppingCart
        )
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }


        public IActionResult Checkout()
        {
            return View();
        }
    }
}
