using System.ComponentModel.DataAnnotations;

namespace Maganmakcore.Models
{
    public class Proizvod
    {
        public int Id { get; set; }
        [Display(Name = "Име")]
        [Required(ErrorMessage = "Ве молиме внесете го името на производот")]
        public string ime { get; set; }

        [Display(Name = "Краток опис")]
        public string kratok_opis { get; set; }

        [Display(Name = "Долг опис")]
        public string dolg_opis { get; set; }

        [Display(Name = "Слика")]
        /* [DataType(DataType.ImageUrl)]*/
        public string slika { get; set; }

        [Display(Name = "Проспект")]
        [DataType(DataType.Url)]
        public string prospekt_link { get; set; }

        [Display(Name = "Упатство")]
        [DataType(DataType.Url)]
        public string upatstvo_link { get; set; }

        [Required(ErrorMessage = "Ве молиме внесете ја цената на производот")]
        [Display(Name = "Цена (во денари)")]
        public decimal Cena { get; set; }

       [Display(Name = "Категорија")]
        public Kategorija_Proizvod kategorija_proizvodi { get; set; }

        public int kategorija_proizvodiKategorijaId { get; set; }

    }
}
