using Maganmakcore.Services;
using Maganmakcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Maganmakcore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderData db;
        private readonly ShoppingCart sc;

        public OrderController(IOrderData db, ShoppingCart sc)
        {
            this.db = db;
            this.sc = sc;
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
    }
}
