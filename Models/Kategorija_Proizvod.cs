using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Maganmakcore.Models
{
    public class Kategorija_Proizvod
    {
        [Key]
        public int KategorijaId { get; set; }

        [Display(Name = "Име на категорија")]
        public string KategorijaIme { get; set; }


        public List<Proizvod> Proizvodi { get; set; }
    }
}
