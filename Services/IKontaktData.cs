using Maganmakcore.Models;
using System.Collections.Generic;

namespace Maganmakcore.Services
{
    public interface IKontaktData
    {
        IEnumerable<Kontakt> GetAll();
        Kontakt Get(int id);
        void Add(Kontakt kontakt);
        void Delete(int id);
    }
}
