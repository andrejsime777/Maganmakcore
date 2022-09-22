using Maganmakcore.Models;
using Maganmakcore.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maganmakcore.Controllers
{
    public class BrzLinkController : Controller
    {
        private readonly IBrzLinkData db;

        public BrzLinkController(IBrzLinkData db)
        {
            this.db = db;
        }
        [Authorize]
        public ActionResult Index()
        {
            /*ViewBag.Message = "Страна за преглед и промена на брзи линкови";*/
            var model = db.GetAll();
            return View(model);
        }
        [Authorize]
        public ActionResult nov_link()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult nov_link(Brz_link brz_link)
        {
            if (ModelState.IsValid)
            {
                db.Add(brz_link);
                ViewBag.news = "Линкот е успешно додаден";
                return RedirectToAction("Index");
            }
            return View();
        }
        [Authorize]
        [HttpGet]
        public ActionResult Izmeni(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                /*return HttpNotFound();*/
                return View("NotFound");
            }
            return View(model);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Izmeni(Brz_link brz_link)
        {
            if (ModelState.IsValid)
            {
                db.Update(brz_link);

                ViewBag.news = "Линкот е успешно изменет";
                return RedirectToAction("Index");
            }
            return View(brz_link);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Izbrishi(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Izbrishi(int id, IFormCollection form)
        {
            db.Delete(id);
            ViewBag.news = "Линкот е успешно избришан";
            return RedirectToAction("Index");
        }
    }
}
