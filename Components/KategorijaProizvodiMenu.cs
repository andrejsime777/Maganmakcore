using Microsoft.AspNetCore.Mvc;
using Maganmakcore.Services;
using System.Linq;

namespace Maganmakcore.Components
{
    public class KategorijaProizvodiMenu : ViewComponent
    {
        private readonly IKategorijaProizvodData db;

        public KategorijaProizvodiMenu(IKategorijaProizvodData db)
        {
            this.db = db;   
        }

        public IViewComponentResult Invoke()
        {
            var kategorii = db.SiteKategorii.OrderBy(k => k.KategorijaIme);
            return View(kategorii);
        }
    }
}
