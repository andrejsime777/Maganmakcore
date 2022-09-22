using Maganmakcore.Services;
using Maganmakcore.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Maganmakcore.Components
{
    public class BrzLinkView : ViewComponent
    {
        private readonly IBrzLinkData db;

        public BrzLinkView( IBrzLinkData db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke()
        {
            var brzlinkView = new BrzLinkViewModel();
            brzlinkView.brzlink = db.GetAll();
            return View(brzlinkView);
        }
    }
}
