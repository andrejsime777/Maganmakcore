using Maganmakcore.Data;
using Maganmakcore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Maganmakcore.Services
{
    public class SqlPocetnaData : IPocetnaData
    {
        private readonly ApplicationDbContext db;

        public SqlPocetnaData(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Pocetna> SiteSliki
        {
            get
            {
                return db.sliki_pocetna.OrderBy(s => s.Id);
            }
        }

        public void Add(Pocetna pocetna)
        {
            db.sliki_pocetna.Add(pocetna);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var slika = db.sliki_pocetna.Find(id);
            db.sliki_pocetna.Remove(slika);
            db.SaveChanges();
        }

        public Pocetna Get(int id)
        {
            return db.sliki_pocetna.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Pocetna> GetAll()
        {
            return from p in db.sliki_pocetna
                   orderby p.Id
                   select p;
        }

        public void Update(Pocetna pocetna)
        {
            var entry = db.Entry(pocetna);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
