using Maganmakcore.Models;
using Maganmakcore.Services;
using Maganmakcore.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Maganmakcore.Controllers
{
    public class ProgramController : Controller
    {
        private readonly IConfiguration config;
        private readonly IProgramData db;
        private readonly IKategorijaProgramData dbktg;
        private readonly IWebHostEnvironment _webhost;

        public ProgramController(IConfiguration config, IProgramData db, IKategorijaProgramData dbktg, IWebHostEnvironment _webhost)
        {
            this.config = config;
            this.db = db;
            this.dbktg = dbktg;
            this._webhost = _webhost;
        }


        public ActionResult Index(string kategorija)
        {
            IEnumerable<Programm> programi;
            string momentalna_kategorija;


            if (string.IsNullOrEmpty(kategorija))
            {
                programi = db.SiteProgrami.OrderBy(p => p.Id);
                momentalna_kategorija = "Сите програми";
                ViewBag.Message = "Тука може да ги погледнете и преземете сите програми на Маган-Мак";
            }
            else
            {
                programi = db.SiteProgrami.Where(p => p.kategorija_programi.KategorijaIme == kategorija).OrderBy(p => p.Id);
                momentalna_kategorija = dbktg.SiteKategorii.FirstOrDefault(c => c.KategorijaIme == kategorija)?.KategorijaIme;
                ViewBag.Message = "Тука може да ги погледнете и преземете " + momentalna_kategorija.ToLower() + " на Маган-Мак";
            }

            

            return View(new ProgramViewModel
            {
                Programi = programi,
                momentalna_kategorija = momentalna_kategorija
            });
        }

        [Authorize]
        public ActionResult Detali1(int id)
        {
            var model = db.GetProgramById(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [Authorize]
        public ActionResult Index1()
        {
            ViewBag.Message = "Страна за додавање и менување на програми и нивните категории";

            var view = new ProgramViewModel();
            view.Programi = db.SiteProgrami;
            view.Kategorija = dbktg.SiteKategorii;

            /*var view = db.GetAll();*/

            return View(view);
        }

        [Authorize]
        public ActionResult nov_program()
        {
            var lista = (from kategorija in dbktg.SiteKategorii
                         select new SelectListItem()
                         {
                             Text = kategorija.KategorijaIme,
                             Value = kategorija.KategorijaId.ToString()
                         }).ToList();

            lista.Insert(0, new SelectListItem()
            {
                Text = "---Избери категорија---",
                Value = string.Empty
            });

            ViewBag.lista = lista;
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> nov_program(Programm program, IFormFile postedFile)
        {
            if (postedFile != null)
            {
                string fileName = Path.GetFileName(DateTime.Now.Millisecond.ToString() + DateTime.Now.DayOfYear.ToString() + postedFile.FileName);
                var savePdf = Path.Combine(_webhost.WebRootPath, "sodrzhina/Programi", fileName);
                var savePdf1 = Path.Combine("/sodrzhina/Programi", fileName);
                string pdfext = Path.GetExtension(postedFile.FileName);

                if (pdfext == ".pdf")
                {
                    using (var uploadimg = new FileStream(savePdf, FileMode.Create))
                    {
                        await postedFile.CopyToAsync(uploadimg);
                        program.pdf_link = savePdf1;
                    }
                }
                else
                {
                    TempData["izvestuvanje_greska"] = "Програмата не е во .pdf формат";
                    return View(program);
                }
            }
            else
            {
                program.pdf_link = null;
            }

            if (ModelState.IsValid)
            {
                TempData["izvestuvanje"] = "Програмот е успешно додаден";
                db.Add(program);
                return RedirectToAction("Detali1", new { id = program.Id });
            }

            TempData["izvestuvanje_greska"] = "Има некоја грешка.";
            return View(program);
        }


        [Authorize]
        [HttpGet]
        public ActionResult Izmeni(int id)
        {
            var model = db.GetProgramById(id);
            if (model == null)
            {
                return View("NotFound");
            }

            var lista = (from kategorija in dbktg.SiteKategorii
                         select new SelectListItem()
                         {
                             Text = kategorija.KategorijaIme,
                             Value = kategorija.KategorijaId.ToString()
                         }).ToList();

            lista.Insert(0, new SelectListItem()
            {
                Text = "---Избери категорија---",
                Value = string.Empty
            });

            ViewBag.lista = lista;
            TempData["pdf"] = model.pdf_link;
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Izmeni(Programm program, IFormFile postedFile)
        {
            if (postedFile == null)
            {
                program.pdf_link = (string)TempData["pdf"];
            }
            else
            {
                string fileName = Path.GetFileName(DateTime.Now.Millisecond.ToString() + DateTime.Now.DayOfYear.ToString() + postedFile.FileName);
                var savePdf = Path.Combine(_webhost.WebRootPath, "sodrzhina/Programi", fileName);
                var savePdf1 = Path.Combine("/sodrzhina/Programi", fileName);
                string pdfext = Path.GetExtension(postedFile.FileName);

                if (pdfext == ".pdf")
                {
                    if (TempData["pdf"] != null)
                    {
                        string postoecki = (string)TempData["pdf"];
                        var zabrisenje = Path.Combine(_webhost.WebRootPath + postoecki);
                        FileInfo file = new FileInfo(zabrisenje);
                        file.Delete();
                    }
                    else { }

                    using (var uploadimg = new FileStream(savePdf, FileMode.Create))
                    {
                        await postedFile.CopyToAsync(uploadimg);
                        program.pdf_link = savePdf1;
                    }
                }
                else
                {
                    TempData["izvestuvanje_greska"] = "Програмата не е во .pdf формат";
                    return View(program);
                }
            }

            if (ModelState.IsValid)
            {
                TempData["izvestuvanje"] = "Програмата е успешно изменета";
                db.Update(program);

                return RedirectToAction("Detali1", new { id = program.Id });
            }
            TempData["izvestuvanje_greska"] = "Има некоја грешка.";
            return View(program);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Izbrishi(int id)
        {
            var model = db.GetProgramById(id);
            if (model == null)
            {
                return View("NotFound");
            }
            TempData["pdf1"] = model.pdf_link;
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Izbrishi(int id, IFormCollection form)
        {
            if (TempData["pdf1"] != null)
            {
                string postoecki = (string)TempData["pdf1"];
                var zabrisenje = Path.Combine(_webhost.WebRootPath + postoecki);
                FileInfo file = new FileInfo(zabrisenje);
                file.Delete();
            }
            else { }

            TempData["izvestuvanje"] = "Производот е успешно избришан!";
            db.Delete(id);
            return RedirectToAction("Index1");
        }

        [Authorize]
        public ActionResult nova_kategorija()
        {
            ViewBag.Message = "Додади нова категорија на програми";
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult nova_kategorija(Kategorija_Program kategorija)
        {
            if (ModelState.IsValid)
            {
                dbktg.Add(kategorija);
                TempData["izvestuvanje"] = "Категоријата е успешно додадена";
                return RedirectToAction("Index1");
            }
            return View();
        }

        [Authorize]
        public ActionResult Izmeni_kategorija(int id)
        {
            var model = dbktg.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Izmeni_kategorija(Kategorija_Program kategorija)
        {
            if (ModelState.IsValid)
            {
                dbktg.Update(kategorija);
                TempData["izvestuvanje"] = "Категоријата е успешно изменета";
                return RedirectToAction("Index1");
            }
            return View();
        }

        [Authorize]
        public ActionResult Izbrishi_kategorija(int id)
        {
            var model = dbktg.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Izbrishi_kategorija(int id, IFormCollection form)
        {
            if (ModelState.IsValid)
            {
                dbktg.Delete(id);
                TempData["izvestuvanje"] = "Категоријата е успешно избришана";
                return RedirectToAction("Index1");
            }
            return View();
        }

    }
}
