using Maganmakcore.Models;
using System.Collections.Generic;

namespace Maganmakcore.Services
{
    public interface IBrzLinkData
    {
        IEnumerable<Brz_link> GetAll();
        Brz_link Get(int id);
        void Add(Brz_link brz_link);
        void Update(Brz_link brz_link);
        void Delete(int id);
    }
}
