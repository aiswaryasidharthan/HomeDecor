using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbcontext;
        private readonly ShoppingCart _shoppingcart;
        public OrderRepository(AppDbContext appDbcontext, ShoppingCart shoppingcart)
            
        {
            _appDbcontext = appDbcontext;
            _shoppingcart = shoppingcart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingcart.GetShoppingCartTotal();
            _appDbcontext.Orders.Add(order);
            _appDbcontext.SaveChanges();

            var shoppingCartitems = _shoppingcart.GetShoppingCartItems();
            foreach(var shoppingCartitem in shoppingCartitems)
            {
                var orderDeatail = new OrderDetail
                {
                    Amount = shoppingCartitem.Amount,
                    Price = shoppingCartitem.Shop.Price,
                    ShopId = shoppingCartitem.Shop.ShopId,
                    OrderId = order.OrderId
                };
                _appDbcontext.OrderDetails.Add(orderDeatail);

            }
            _appDbcontext.SaveChanges();
        }
    }
}
