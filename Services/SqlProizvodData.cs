using Maganmakcore.Data;
using Maganmakcore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Maganmakcore.Services
{
    public class SqlProizvodData : IProizvodData
    {
        private readonly ApplicationDbContext db;

        public SqlProizvodData(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Add(Proizvod proizvod)
        {
            db.Proizvodi.Add(proizvod);
            db.SaveChanges();
        }

        public Proizvod Get(int id)
        {
            return db.Proizvodi.Include(c=>c.kategorija_proizvodi).FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Proizvod> GetAll()
        {
            return from p in db.Proizvodi
                   orderby p.ime
                   select p;
        }

        public IEnumerable<Proizvod> SiteProizvodi
        {
            get
            {
                return db.Proizvodi.Include(c => c.kategorija_proizvodi).OrderByDescending(p => p.Id);
            }
        }

        public void Update(Proizvod proizvod)
        {
            var entry = db.Entry(proizvod);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var proizvod = db.Proizvodi.Find(id);
            db.Proizvodi.Remove(proizvod);
            db.SaveChanges();
        }
    }
}
