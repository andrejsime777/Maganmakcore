using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganmakcore.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProizvodId { get; set; }
        public int Amount { get; set; }
        public decimal Cena { get; set; }
        public Proizvod Proizvod { get; set; }
        public Order Order { get; set; }
    }
}
