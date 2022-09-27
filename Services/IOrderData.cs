using Maganmakcore.Models;
using System.Collections.Generic;

namespace Maganmakcore.Services
{
    public interface IOrderData
    {
        void CreateOrder(Order order);
        IEnumerable<Order> SiteNaracki { get; }
        Order Get(int id);
        void Delete(int id);
    }
}
