using Maganmakcore.Data;
using Maganmakcore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganmakcore.Services
{
    public class SqlOrderData : IOrderData
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public SqlOrderData(ApplicationDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public IEnumerable<Order> SiteNaracki
        {
            get
            {
                return _appDbContext.Orders.Include(d => d.OrderDetails).OrderByDescending(n => n.OrderId);
            }
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();
            //adding the order with its details

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    ProizvodId = shoppingCartItem.proizvod.Id,
                    Cena = shoppingCartItem.proizvod.Cena
                };

                order.OrderDetails.Add(orderDetail);
            }

            _appDbContext.Orders.Add(order);

            _appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var order = _appDbContext.Orders.Find(id);
            _appDbContext.Orders.Remove(order);
            _appDbContext.SaveChanges();
        }

        public Order Get(int id)
        {
           return _appDbContext.Orders.FirstOrDefault(p => p.OrderId == id);
        }
    }
}