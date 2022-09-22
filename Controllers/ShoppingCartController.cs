using Maganmakcore.Models;
using Maganmakcore.Services;
using Maganmakcore.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Maganmakcore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProizvodData db;
        private readonly ShoppingCart sc;

        public ShoppingCartController(IProizvodData db, ShoppingCart sc)
        {
            this.db = db;
            this.sc = sc;
        }

        public ViewResult Index()
        {
            ViewBag.Message = "Ова се вашите производи во вашата кошничка";
            var items = sc.GetShoppingCartItems();
            sc.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = sc,
                ShoppingCartTotal = sc.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int proizvodId)
        {
            var selectedProizvod = db.SiteProizvodi.FirstOrDefault(p => p.Id == proizvodId);

            if (selectedProizvod != null)
            {
                sc.AddToCart(selectedProizvod, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int proizvodId)
        {
            var selectedProizvod = db.SiteProizvodi.FirstOrDefault(p => p.Id == proizvodId);

            if (selectedProizvod != null)
            {
                sc.RemoveFromCart(selectedProizvod);
            }
            return RedirectToAction("Index");
        }
    }
}
