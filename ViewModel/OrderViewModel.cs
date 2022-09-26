using Maganmakcore.Models;
using System.Collections.Generic;

namespace Maganmakcore.ViewModel
{
    public class OrderViewModel
    { 
        public IEnumerable<Order> Orders { get; set; }
        public Order order { get; set; }
        public IEnumerable<OrderDetail> Details { get; set; }
        public OrderDetail Detail { get; set; }
        public decimal Cena { get; set; }
        public Proizvod proizvod { get; set; }
        public int Amount { get; set; }
        public decimal VkupnaCena { get; set; }

    }
}
