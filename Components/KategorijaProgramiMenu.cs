using Maganmakcore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Maganmakcore.Components
{
    public class KategorijaProgramiMenu : ViewComponent
    {
        private readonly IKategorijaProgramData db;

        public KategorijaProgramiMenu(IKategorijaProgramData db)
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
