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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Maganmakcore.Controllers
{
    public class ProizvodController : Controller
    {
        private readonly IConfiguration config;
        private readonly IProizvodData db;
        private readonly IKategorijaProizvodData dbktg;
        private readonly IWebHostEnvironment _webhost;

        public ProizvodController(IConfiguration config, IProizvodData db, IKategorijaProizvodData dbktg, IWebHostEnvironment _webhost)
        {
            this.config = config;
            this.db = db;
            this.dbktg = dbktg;
            this._webhost = _webhost;
        }

        
        public ActionResult Index(string kategorija)
        {
            IEnumerable<Proizvod> proizvodi;
            string momentalna_kategorija;


            if (string.IsNullOrEmpty(kategorija))
            {
                proizvodi = db.SiteProizvodi.OrderBy(p => p.Id);
                momentalna_kategorija = "Сите производи";
            }
            else
            {
                proizvodi = db.SiteProizvodi.Where(p => p.kategorija_proizvodi.KategorijaIme == kategorija).OrderBy(p => p.Id);
                momentalna_kategorija = dbktg.SiteKategorii.FirstOrDefault(c => c.KategorijaIme == kategorija)?.KategorijaIme;
            }

            ViewBag.Message = "Тука може да ја погледнете палетата на производи на Маган-Мак";
            
            return View(new ProizvodViewModel
            {
                Proizvodi = proizvodi,
                momentalna_kategorija = momentalna_kategorija
            });
        }

        [Authorize]
        public ActionResult Index1()
        {
            ViewBag.Message = "Страна за додавање и менување на производи и нивните категории";

            var view = new ProizvodViewModel();
            view.Proizvodi = db.GetAll();
            view.Kategorija_Proizvod = dbktg.GetAll();

            /*var view = db.GetAll();*/

            return View(view);
        }
        
        public ActionResult Detali(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            ViewBag.Message = "Детали за " + model.ime;
            return View(model);
        }

        [Authorize]
        public ActionResult Detali1(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            ViewBag.Message = "Детали за " + model.ime;
            return View(model);
        }
        [Authorize]
        public ActionResult nov_proizvod()
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
                Value=string.Empty
            });

            ViewBag.lista = lista;
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> nov_proizvod(Proizvod proizvod, IFormFile postedFile, IFormFile postedFile1, IFormFile postedFile2)
        {

            if(postedFile != null)
            {
                string fileName = Path.GetFileName(DateTime.Now.Millisecond.ToString() + DateTime.Now.DayOfYear.ToString() + postedFile.FileName);
                var saveImg = Path.Combine(_webhost.WebRootPath, "sodrzhina/Images", fileName);
                var saveImg1 = Path.Combine("/sodrzhina/Images", fileName);
                string imgext = Path.GetExtension(postedFile.FileName);

                if(imgext == ".jpg" || imgext == ".png")
                {
                    using (var uploadimg = new FileStream(saveImg, FileMode.Create))
                    {
                        await postedFile.CopyToAsync(uploadimg);
                        proizvod.slika = saveImg1;
                    }
                }
                else
                {
                    TempData["izvestuvanje_greska"] = "Сликата не е во .jpg или .png формат";
                    return View(proizvod);
                }
            }
            else
            {
                proizvod.slika = null;
            }

            if (postedFile1 != null)
            {
                string fileName1 = Path.GetFileName(DateTime.Now.Millisecond.ToString() + DateTime.Now.DayOfYear.ToString() + postedFile1.FileName);
                var saveprospekt = Path.Combine(_webhost.WebRootPath, "sodrzhina/Prospekti", fileName1);
                var saveprospekt1 = Path.Combine("/sodrzhina/Prospekti", fileName1);
                string prospektext = Path.GetExtension(postedFile1.FileName);

                if (prospektext == ".pdf")
                {
                    using (var uploadprospekt = new FileStream(saveprospekt, FileMode.Create))
                    {
                        await postedFile1.CopyToAsync(uploadprospekt);
                        proizvod.prospekt_link = saveprospekt1;
                    }
                }
                else
                {
                    TempData["izvestuvanje_greska"] = "Проспектот не е во .pdf формат";
                    return View(proizvod);
                }
            }
            else
            {
                proizvod.prospekt_link = null;
            }


            if (postedFile2 != null)
            {
                string fileName2 = Path.GetFileName(DateTime.Now.Millisecond.ToString() + DateTime.Now.DayOfYear.ToString() + postedFile2.FileName);
                var saveupatstvo = Path.Combine(_webhost.WebRootPath, "sodrzhina/Prospekti", fileName2);
                var saveupatstvo1 = Path.Combine("/sodrzhina/Prospekti", fileName2);
                string upatstvoext = Path.GetExtension(postedFile2.FileName);

                if (upatstvoext == ".pdf")
                {
                    using (var uploadupatstvo = new FileStream(saveupatstvo, FileMode.Create))
                    {
                        await postedFile2.CopyToAsync(uploadupatstvo);
                        proizvod.upatstvo_link = saveupatstvo1;
                    }
                }
                else
                {
                    TempData["izvestuvanje_greska"] = "Упатството не е во .pdf формат";
                    return View(proizvod);
                }
            }
            else
            {
                proizvod.upatstvo_link = null;
            }
                
            if (ModelState.IsValid)
            {
                TempData["izvestuvanje"] = "Производот е успешно додаден";
                db.Add(proizvod);
                return RedirectToAction("Detali1", new { id = proizvod.Id });
            }

            TempData["izvestuvanje_greska"] = "Има некоја грешка.";
            return View(proizvod);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Izmeni(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return NotFound();
            }
            TempData["slika"] = model.slika;
            TempData["prospekt"] = model.prospekt_link;
            TempData["upatstvo"] = model.upatstvo_link;
            return View(model);            
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Izmeni(Proizvod proizvod, IFormFile postedFile, IFormFile postedFile1, IFormFile postedFile2)
        {

            
            if (postedFile == null)
            {
                proizvod.slika = (string)TempData["slika"];
            }
            else
            {
                if(TempData["slika"] != null) 
                {
                    string postoecki = (string)TempData["slika"];
                    var zabrisenje = Path.Combine(_webhost.WebRootPath + postoecki);
                    FileInfo file = new FileInfo(zabrisenje);
                    file.Delete();
                }
                else { }
                

                string fileName = Path.GetFileName(DateTime.Now.Millisecond.ToString() + DateTime.Now.DayOfYear.ToString() + postedFile.FileName);

                var saveImg = Path.Combine(_webhost.WebRootPath, "sodrzhina/Images", fileName);
                var saveImg1 = Path.Combine("/sodrzhina/Images", fileName);
                string imgext = Path.GetExtension(postedFile.FileName);

                if (imgext == ".jpg" || imgext == ".png")
                {
                    using (var uploadimg = new FileStream(saveImg, FileMode.Create))
                    {
                        await postedFile.CopyToAsync(uploadimg);
                        proizvod.slika = saveImg1;
                    }
                }
                else
                {
                    TempData["izvestuvanje_greska"] = "Има некоја грешка. Проверете дали сликата e .jpg или .png, и дали упатството и проспектот се .pdf фајлови";
                    return View(proizvod);
                }
            }

            if (postedFile1 == null)
            {
                proizvod.prospekt_link = (string)TempData["prospekt"];
            }
            else
            {
                if (TempData["prospekt"] != null)
                {
                    string postoecki = (string)TempData["prospekt"];
                    var zabrisenje = Path.Combine(_webhost.WebRootPath + postoecki);
                    FileInfo file = new FileInfo(zabrisenje);
                    file.Delete();
                }
                else { }
               

                string fileName1 = Path.GetFileName(DateTime.Now.Millisecond.ToString() + DateTime.Now.DayOfYear.ToString() + postedFile1.FileName);
                var saveprospekt = Path.Combine(_webhost.WebRootPath, "sodrzhina/Prospekti", fileName1);
                var saveprospekt1 = Path.Combine("/sodrzhina/Prospekti", fileName1);
                string prospektext = Path.GetExtension(postedFile1.FileName);

                if (prospektext == ".pdf")
                {
                    using (var uploadprospekt = new FileStream(saveprospekt, FileMode.Create))
                    {
                        await postedFile1.CopyToAsync(uploadprospekt);
                        proizvod.prospekt_link = saveprospekt1;
                    }
                }
                else
                {
                    TempData["izvestuvanje_greska"] = "Има некоја грешка. Проверете дали сликата e .jpg или .png, и дали упатството и проспектот се .pdf фајлови";
                    return View(proizvod);
                }
            }

            if (postedFile2 == null)
            {
                proizvod.upatstvo_link = (string)TempData["upatstvo"];
            }
            else
            {
                if (TempData["upatstvo"] != null)
                {
                    string postoecki = (string)TempData["upatstvo"];
                    var zabrisenje = Path.Combine(_webhost.WebRootPath + postoecki);
                    FileInfo file = new FileInfo(zabrisenje);
                    file.Delete();
                }
                else { }
                

                string fileName2 = Path.GetFileName(DateTime.Now.Millisecond.ToString() + DateTime.Now.DayOfYear.ToString() + postedFile2.FileName);
                var saveupatstvo = Path.Combine(_webhost.WebRootPath, "sodrzhina/Prospekti", fileName2);
                var saveupatstvo1 = Path.Combine("/sodrzhina/Prospekti", fileName2);
                string upatstvoext = Path.GetExtension(postedFile2.FileName);

                if (upatstvoext == ".pdf")
                {
                    using (var uploadupatstvo = new FileStream(saveupatstvo, FileMode.Create))
                    {
                        await postedFile2.CopyToAsync(uploadupatstvo);
                        proizvod.upatstvo_link = saveupatstvo1;
                    }
                }
                else
                {
                    TempData["izvestuvanje_greska"] = "Има некоја грешка. Проверете дали сликата e .jpg или .png, и дали упатството и проспектот се .pdf фајлови";
                    return View(proizvod);
                }
            }






            if (ModelState.IsValid)
            {
                TempData["izvestuvanje"] = "Производот е успешно изменет";
                db.Update(proizvod);

                return RedirectToAction("Detali1", new { id = proizvod.Id });
            }
            return View(proizvod);
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
            TempData["slika1"] = model.slika;
            TempData["prospekt1"] = model.prospekt_link;
            TempData["upatstvo1"] = model.upatstvo_link;
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Izbrishi(int id, IFormCollection form)
        {
            if (TempData["slika1"] != null) 
            { 
                string postoecki = (string)TempData["slika1"];
                var zabrisenje = Path.Combine(_webhost.WebRootPath + postoecki);
                FileInfo file = new FileInfo(zabrisenje);
                file.Delete();
            }

            if (TempData["prospekt1"] != null)
            {
                string postoecki1 = (string)TempData["prospekt1"];
                var zabrisenje1 = Path.Combine(_webhost.WebRootPath + postoecki1);
                FileInfo file1 = new FileInfo(zabrisenje1);
                file1.Delete();
            }

            if (TempData["upatstvo1"] != null)
            {
                string postoecki2 = (string)TempData["upatstvo1"];
                var zabrisenje2 = Path.Combine(_webhost.WebRootPath + postoecki2);
                FileInfo file2 = new FileInfo(zabrisenje2);
                file2.Delete();
            }

            TempData["izvestuvanje"] = "Производот е успешно избришан!";
            db.Delete(id);
            return RedirectToAction("Index1");
        }



        [Authorize]
        public ActionResult nova_kategorija()
        {
            ViewBag.Message = "Додади нова категорија на производи";
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult nova_kategorija(Kategorija_Proizvod kategorija)
        {
            if (ModelState.IsValid)
            {
                dbktg.Add(kategorija);
                TempData["izvestuvanje"] = "Категоријата е успешно додадена";
                return RedirectToAction("Index1");
            }
            return View();
        }
    }
}
