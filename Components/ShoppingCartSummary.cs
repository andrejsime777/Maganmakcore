using Maganmakcore.Models;
using Maganmakcore.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Maganmakcore.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart sc;

        public ShoppingCartSummary(ShoppingCart sc)
        {
            this.sc = sc;
        }

        public IViewComponentResult Invoke()
        {
            var items = sc.GetShoppingCartItems();
            sc.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = sc,
                ShoppingCartTotal = sc.GetShoppingCartTotal(),
            };
            return View(shoppingCartViewModel);
        }
    }
}
