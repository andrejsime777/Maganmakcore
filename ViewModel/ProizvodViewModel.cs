using Maganmakcore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Maganmakcore.ViewModel
{
    public class ProizvodViewModel
    {
        public IEnumerable<Proizvod> Proizvodi { get; set; }
        public string momentalna_kategorija { get; set; }
        public IEnumerable<Kategorija_Proizvod> Kategorija_Proizvod { get; set; }
        public int KategorijaID { get; set; }
        public List<SelectListItem> lista { get; set; }
    }
}
