using Maganmakcore.Services;
using Maganmakcore.Models;
using Microsoft.AspNetCore.Mvc;
using Maganmakcore.ViewModel;
using System.Collections.Generic;
using Maganmakcore.Data;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace Maganmakcore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderData db;
        private readonly ShoppingCart sc;
        private readonly IOrderDetailData detail;

        public OrderController(IOrderData db, ShoppingCart sc, IOrderDetailData detail)
        {
            this.db = db;
            this.sc = sc;
            this.detail = detail;
        }

        public IActionResult Narachka()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Narachka(Order order)
        {
            var items = sc.GetShoppingCartItems();
            sc.ShoppingCartItems = items;

            if(sc.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Вашата кошничка е празна, прво додадете некој производ");
            }

            if (ModelState.IsValid)
            {
                db.CreateOrder(order);
                sc.ClearCart();
                return RedirectToAction("UspeshnaNarachka");
            }
            return View(order);
        }

        public IActionResult UspeshnaNarachka()
        {
            ViewBag.Message = "Ви благодариме за нарачката. Производите ќе бидат доставени најбрзо што може. Чекањето е од 1-3 дена.";

            return View();
        }

        [Authorize]
        public ActionResult List()
        {
            ViewBag.Message = "Преглед на нарачки";
            var model = new OrderViewModel();
            model.Orders = db.SiteNaracki;

            return View(model);
        }

        [Authorize]
        public ActionResult Detali1(int id)
        {
            var model = new OrderViewModel();
            model.order = db.Get(id);
            model.Details = detail.GetAll(id);

            if (model.order == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [Authorize]
        public ActionResult Izbrishi(int id)
        {
            var model = new OrderViewModel();
            model.order = db.Get(id);
            model.Details = detail.GetAll(id);
            if (model.order == null)
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
            TempData["izvestuvanje"] = "Нарачката е успешно избришана!";
            db.Delete(id);
            return RedirectToAction("List");
        }

    }
}
