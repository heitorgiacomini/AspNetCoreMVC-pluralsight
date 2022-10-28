namespace AspNetCoreEmpty.Models
{
    public class OrderRepository : IOrderRepository
    {

        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(
            AppDbContext appDbContext,
            ShoppingCart shoppingCart
        )
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.Order.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    PieId = item.Pie.PieId,
                    OrderId = order.OrderId,
                    Price = item.Pie.Price
                };

                _appDbContext.OrderDetail.Add(orderDetail);
            }

            _appDbContext.SaveChanges();

        }
    }
}
