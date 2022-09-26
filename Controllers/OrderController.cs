using Maganmakcore.Services;
using Maganmakcore.Models;
using Microsoft.AspNetCore.Mvc;
using Maganmakcore.ViewModel;
using System.Collections.Generic;
using Maganmakcore.Data;
using System.Linq;

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
                ModelState.AddModelError("", "Вашата кошничка е празна, додадете некој производ прво");
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

        public ActionResult List()
        {
            var model = new OrderViewModel();
            model.Orders = db.SiteNaracki;

            return View(model);
        }

        public ActionResult Detali1(int id)
        {
            var model = new OrderViewModel();
            model.order = db.Get(id);/*
            var detal = detail.Get(id);*/

            model.Details = detail.GetAll(id);

            /*            foreach(var item in detal)
                        {
                            model.Cena = item.Cena;
                            model.Amount = item.Amount;
                            model.proizvod = item.Proizvod;
                            model.VkupnaCena = (item.Cena * item.Amount);
                        }*/

            if (model.order == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
    }
}
