using Maganmakcore.Models;
using System.Collections.Generic;

namespace Maganmakcore.ViewModel
{
    public class ProgramViewModel
    {
        public IEnumerable<Programm> Programi { get; set; }
        public string momentalna_kategorija { get; set; }

        public IEnumerable<Kategorija_Program> Kategorija { get; set; }
    }
}
