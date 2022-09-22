using Maganmakcore.Data;
using Maganmakcore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Maganmakcore.Services
{
    public class SqlKategorijaProizvodData : IKategorijaProizvodData
    {
        private readonly ApplicationDbContext db;

        public SqlKategorijaProizvodData(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Kategorija_Proizvod> SiteKategorii => db.kategorija_Proizvodi;

        public void Add(Kategorija_Proizvod kategorija)
        {
            db.kategorija_Proizvodi.Add(kategorija);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var kategorija = db.kategorija_Proizvodi.Find(id);
            db.kategorija_Proizvodi.Remove(kategorija);
            db.SaveChanges();
        }

        public Kategorija_Proizvod Get(int id)
        {
            return db.kategorija_Proizvodi.FirstOrDefault(p => p.KategorijaId == id);
        }

        public IEnumerable<Kategorija_Proizvod> GetAll()
        {
            return from k in db.kategorija_Proizvodi
                   orderby k.KategorijaIme
                   select k;
        }

        public void Update(Kategorija_Proizvod kategorija)
        {
            var entry = db.Entry(kategorija);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
