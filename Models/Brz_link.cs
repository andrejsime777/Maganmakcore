using System.ComponentModel.DataAnnotations;

namespace Maganmakcore.Models
{
    public class Brz_link
    {
        public int Id { get; set; }

        [Display(Name = "Име")]
        [Required]
        public string Ime { get; set; }

        [Display(Name = "Линк")]
        public string Link { get; set; }
    }
}
