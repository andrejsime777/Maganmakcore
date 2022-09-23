using Maganmakcore.Data;
using Maganmakcore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Maganmakcore.Services
{
    public class SqlProgramData : IProgramData
    {
        private readonly ApplicationDbContext db;

        public SqlProgramData(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Programm> SiteProgrami
        {
            get
            {
                return db.Programi.Include(c => c.kategorija_programi).OrderByDescending(p => p.Id);
            }
        }

        public void Add(Programm program)
        {
            db.Programi.Add(program);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var program = db.Programi.Find(id);
            db.Programi.Remove(program);
            db.SaveChanges();
        }

        public Programm GetProgramById(int programId)
        {
            return db.Programi.Include(c => c.kategorija_programi).FirstOrDefault(p => p.Id == programId);
        }

        public void Update(Programm program)
        {
            var entry = db.Entry(program);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
