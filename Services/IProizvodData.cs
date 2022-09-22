using Maganmakcore.Models;
using System.Collections.Generic;

namespace Maganmakcore.Services
{
    public interface IProizvodData
    {
        IEnumerable<Proizvod> GetAll();
        IEnumerable<Proizvod> SiteProizvodi { get; }
        Proizvod Get(int id);
        void Add(Proizvod proizvod);
        void Update(Proizvod proizvod);
        void Delete(int id);
    }
}
