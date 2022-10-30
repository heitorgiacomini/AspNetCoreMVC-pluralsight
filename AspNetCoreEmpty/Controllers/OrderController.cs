using AspNetCoreEmpty.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEmpty.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrderRepository _orderRepository;

        public OrderController(
            AppDbContext appDbContext,
            ShoppingCart shoppingCart,
            IOrderRepository orderRepository
        )
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
            _orderRepository = orderRepository;
        }


        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItem();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some pies first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order. You'll soon enjoy...";
            return View();
        }
    }
}
