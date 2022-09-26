using Maganmakcore.Models;
using System.Collections.Generic;

namespace Maganmakcore.Services
{
    public interface IPocetnaData
    {
        IEnumerable<Pocetna> GetAll();
        IEnumerable<Pocetna> SiteSliki { get; }
        Pocetna Get(int id);
        void Add(Pocetna pocetna);
        void Update(Pocetna pocetna);
        void Delete(int id);
    }
}
