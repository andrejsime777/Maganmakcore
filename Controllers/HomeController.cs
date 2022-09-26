using Maganmakcore.Models;
using Maganmakcore.Services;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Maganmakcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPocetnaData db;
        private readonly IWebHostEnvironment _webhost;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IPocetnaData db, IWebHostEnvironment _webhost)
        {
            _logger = logger;
            this.db = db;
            this._webhost = _webhost;
        }

        public IActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [Authorize]
        public ActionResult Index1()
        {
            var model = db.GetAll();
            return View(model);
        }

        [Authorize]
        public ActionResult nova_slika()
        {
            ViewBag.message = "Прикачи слика која ќе биде прикажана на почетната страна";
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> nova_slika(Pocetna pocetna, IFormFile postedFile)
        {
            if (postedFile != null)
            {
                string fileName = Path.GetFileName(DateTime.Now.Millisecond.ToString() + DateTime.Now.DayOfYear.ToString() + postedFile.FileName);
                var saveImg = Path.Combine(_webhost.WebRootPath, "sodrzhina/Images/slider", fileName);
                var saveImg1 = Path.Combine("/sodrzhina/Images/slider", fileName);
                string imgext = Path.GetExtension(postedFile.FileName);

                if (imgext == ".jpg" || imgext == ".png")
                {
                    using (var uploadimg = new FileStream(saveImg, FileMode.Create))
                    {
                        await postedFile.CopyToAsync(uploadimg);
                        pocetna.Slika = saveImg1;
                    }
                }
                else
                {
                    TempData["izvestuvanje_greska"] = "Сликата не е во .jpg или .png формат";
                    return View(pocetna);
                }
            }
            else
            {
                pocetna.Slika = null;
            }


            if (ModelState.IsValid)
            {
                db.Add(pocetna);
                TempData["izvestuvanje"] = "Сликата е успешно додадена";
                return RedirectToAction("Index1");
            }
            TempData["izvestuvanje_greska"] = "Има некоја грешка!";
            return View(pocetna);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Izmeni(int id)
        {
            ViewBag.message = "Измена на слика која ќе биде прикажана на почетната страна";
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            TempData["slika"] = model.Slika;
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Izmeni(Pocetna pocetna, IFormFile postedFile)
        {
            if (postedFile == null)
            {
                pocetna.Slika = (string)TempData["pdf"];
            }
            else
            {
                string fileName = Path.GetFileName(DateTime.Now.Millisecond.ToString() + DateTime.Now.DayOfYear.ToString() + postedFile.FileName);
                var saveImg = Path.Combine(_webhost.WebRootPath, "sodrzhina/Images/slider", fileName);
                var saveImg1 = Path.Combine("/sodrzhina/Images/slider", fileName);
                string imgext = Path.GetExtension(postedFile.FileName);

                if (imgext == ".jpg" || imgext == ".png")
                {
                    if (TempData["slika"] != null)
                    {
                        string postoecki = (string)TempData["slika"];
                        var zabrisenje = Path.Combine(_webhost.WebRootPath + postoecki);
                        FileInfo file = new FileInfo(zabrisenje);
                        file.Delete();
                    }
                    else { }

                    using (var uploadimg = new FileStream(saveImg, FileMode.Create))
                    {
                        await postedFile.CopyToAsync(uploadimg);
                        pocetna.Slika = saveImg1;
                    }
                }
                else
                {
                    TempData["izvestuvanje_greska"] = "Сликата не е во .jpg или .png формат";
                    return View(pocetna);
                }
            }


            if (ModelState.IsValid)
            {
                db.Update(pocetna);

                TempData["izvestuvanje"] = "Сликата е успешно променета";
                return RedirectToAction("Index1");
            }
            TempData["izvestuvanje_greska"] = "Има некоја грешка!";
            return View(pocetna);
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
            TempData["izvestuvanje"] = "Сликата е успешно избришана";
            return RedirectToAction("Index1");
        }
    }
}
