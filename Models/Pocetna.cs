using System.ComponentModel.DataAnnotations;

namespace Maganmakcore.Models
{
    public class Pocetna
    {
        public int Id { get; set; }

        [Display(Name = "Слика")]
        public string Slika { get; set; }
    }
}
