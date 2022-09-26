using Maganmakcore.Data;
using Maganmakcore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Maganmakcore.Services
{
    public class SqlOrderDetailData : IOrderDetailData
    {
        private readonly ApplicationDbContext db;

        public SqlOrderDetailData(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<OrderDetail> SiteDetali
        {
            get
            {
                return db.OrderDetails.OrderBy(p=>p.OrderDetailId);
            }
        }
        public OrderDetail Get(int id)
        {
            return db.OrderDetails.Where(p=>p.OrderId==id).FirstOrDefault();
        }

        public IEnumerable<OrderDetail> GetAll(int id)
        {
            return db.OrderDetails.Include(s=>s.Proizvod).Where(p => p.OrderId == id);
        }
    }
}
