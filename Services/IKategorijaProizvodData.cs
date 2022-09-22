using Maganmakcore.Models;
using System.Collections.Generic;

namespace Maganmakcore.Services
{
    public interface IKategorijaProizvodData
    {
        IEnumerable<Kategorija_Proizvod> SiteKategorii { get; }
        IEnumerable<Kategorija_Proizvod> GetAll();
        Kategorija_Proizvod Get(int id);
        void Add(Kategorija_Proizvod kategorija);
        void Update(Kategorija_Proizvod kategorija);
        void Delete(int id);
    }
}
