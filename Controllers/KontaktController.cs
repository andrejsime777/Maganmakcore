using Maganmakcore.Models;
using Maganmakcore.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maganmakcore.Controllers
{
    public class KontaktController : Controller
    {
        private readonly IKontaktData db;

        public KontaktController(IKontaktData db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Тука можете да ја контактирате Маган-Мак";
            return View();
        }

        [HttpPost]
        public ActionResult Index(Kontakt kontakt)
        {
            if (ModelState.IsValid)
            {
                db.Add(kontakt);
                TempData["izvestuvanje_korisnik"] = "Успешно ја пративте контакт формата";
                return RedirectToAction("Index");
            }
            TempData["izvestuvanje_korisnik_greska"] = "Има некоја грешка!";
            return View();
        }
        [Authorize]
        public IActionResult List()
        {
            ViewBag.Message = "Преглед на внесени контакт форми од корисници";
            var model = db.GetAll();
            return View(model);
        }
        [Authorize]
        public IActionResult Izbrishi(int id)
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
        public IActionResult Izbrishi(int id, IFormCollection form)
        {
            db.Delete(id);
            TempData["izvestuvanje"] = "Контакт формата е успешно избришана";
            return RedirectToAction("List");
        }

        public ActionResult reoni()
        {
            return View();
        }
        [Authorize]
        public ActionResult Detali(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
    }
}
