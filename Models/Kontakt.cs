using System.ComponentModel.DataAnnotations;

namespace Maganmakcore.Models
{
    public class Kontakt
    {
        public int Id { get; set; }
        [Display(Name = "Име")]
        public string Ime { get; set; }

        public string Email { get; set; }

        [Display(Name = "Телефонски Број")]
        public string Telefon { get; set; }

        [Display(Name = "Порака")]
        public string Poraka { get; set; }
    }
}
