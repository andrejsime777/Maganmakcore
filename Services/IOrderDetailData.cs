using Maganmakcore.Models;
using System.Collections.Generic;

namespace Maganmakcore.Services
{
    public interface IOrderDetailData
    {
        OrderDetail Get(int id);
        IEnumerable<OrderDetail> GetAll(int id);
        IEnumerable<OrderDetail> SiteDetali { get; }
    }
}
