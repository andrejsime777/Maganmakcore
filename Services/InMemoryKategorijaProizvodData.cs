using Maganmakcore.Models;
using System.Collections.Generic;
using System.Linq;

namespace Maganmakcore.Services
{
    public class InMemoryKategorijaProizvodData : IKategorijaProizvodData
    {
        List<Kategorija_Proizvod> kategorii;

        public InMemoryKategorijaProizvodData()
        {
            kategorii = new List<Kategorija_Proizvod>()
            {
                new Kategorija_Proizvod {KategorijaId=1, KategorijaIme="Заштита на растенија"},
                new Kategorija_Proizvod {KategorijaId=2, KategorijaIme="Исхрана на растенија"},
                new Kategorija_Proizvod {KategorijaId=3, KategorijaIme="Семиња"}
            };
        }



        public IEnumerable<Kategorija_Proizvod> SiteKategorii => 
            new List<Kategorija_Proizvod>
            {
                new Kategorija_Proizvod {KategorijaId=1, KategorijaIme="Заштита на растенија"},
                new Kategorija_Proizvod {KategorijaId=2, KategorijaIme="Исхрана на растенија"},
                new Kategorija_Proizvod {KategorijaId=3, KategorijaIme="Семиња"}
            };




        public void Add(Kategorija_Proizvod kategorija)
        {
            kategorii.Add(kategorija);
            kategorija.KategorijaId = kategorii.Max(p=>p.KategorijaId)+1;

        }

        public void Delete(int id)
        {
            var kategorija = Get(id);
            if (kategorija != null)
            {
                kategorii.Remove(kategorija);
            }
        }

        public Kategorija_Proizvod Get(int id)
        {
            return kategorii.FirstOrDefault(p => p.KategorijaId == id);
        }

        public IEnumerable<Kategorija_Proizvod> GetAll()
        {
            return from r in kategorii
                   orderby r.KategorijaIme
                   select r;
        }

        public void Update(Kategorija_Proizvod kategorija)
        {
            var existing = Get(kategorija.KategorijaId);
            if(existing != null)
            {
                existing.KategorijaIme = kategorija.KategorijaIme;
            }
        }
    }
}
