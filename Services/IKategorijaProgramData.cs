using Maganmakcore.Models;
using System.Collections.Generic;

namespace Maganmakcore.Services
{
    public interface IKategorijaProgramData
    {
        IEnumerable<Kategorija_Program> SiteKategorii { get; }
        Kategorija_Program Get(int id);
        void Add(Kategorija_Program kategorija);
        void Update(Kategorija_Program kategorija);
        void Delete(int id);
    }
}
