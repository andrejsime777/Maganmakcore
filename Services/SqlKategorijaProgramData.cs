using Maganmakcore.Data;
using Maganmakcore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Maganmakcore.Services
{
    public class SqlKategorijaProgramData : IKategorijaProgramData
    {
        private readonly ApplicationDbContext db;

        public SqlKategorijaProgramData(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Kategorija_Program> SiteKategorii => db.kategorija_Programi.OrderByDescending(k => k.KategorijaId);


        public void Add(Kategorija_Program kategorija)
        {
            db.kategorija_Programi.Add(kategorija);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var kategorija = db.kategorija_Programi.Find(id);
            db.kategorija_Programi.Remove(kategorija);
            db.SaveChanges();
        }

        public Kategorija_Program Get(int id)
        {
            return db.kategorija_Programi.FirstOrDefault(p => p.KategorijaId == id);
        }

        public void Update(Kategorija_Program kategorija)
        {
            var entry = db.Entry(kategorija);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
