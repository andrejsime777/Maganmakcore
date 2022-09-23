using System.ComponentModel.DataAnnotations;

namespace Maganmakcore.Models
{
    public class Programm
    {
        public int Id { get; set; }

        [Display(Name = "Име")]
        public string Ime { get; set; }

        [Display(Name = "ПДФ фајл од програмата")]
        public string pdf_link { get; set; }


        [Display(Name = "Категорија")]
        public Kategorija_Program kategorija_programi { get; set; }
        
        public int kategorija_programiKategorijaId { get; set; }
    }
}
