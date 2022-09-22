using Maganmakcore.Data;
using Maganmakcore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Maganmakcore.Services
{
    public class SqlKontaktData : IKontaktData
    {
        private readonly ApplicationDbContext db;

        public SqlKontaktData(ApplicationDbContext db)
        {
            this.db = db;
        }


        public void Add(Kontakt kontakt)
        {
            db.Kontakti.Add(kontakt);
            db.SaveChanges();
        }

        public Kontakt Get(int id)
        {
            return db.Kontakti.FirstOrDefault(p => p.Id == id);
        }

        public void Delete(int id)
        {
            var kontakt = db.Kontakti.Find(id);
            db.Kontakti.Remove(kontakt);
            db.SaveChanges();
        }

        public IEnumerable<Kontakt> GetAll()
        {
           return from b in db.Kontakti
                  orderby b.Ime
                  select b;
        }
    }
}
