using Maganmakcore.Models;
using System.Collections.Generic;

namespace Maganmakcore.Services
{
    public interface IProgramData
    {
        IEnumerable<Programm> SiteProgrami { get; }
        Programm GetProgramById(int programId);
        void Add(Programm program);
        void Update(Programm program);
        void Delete(int id);

    }
}
