namespace Maganmakcore.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Proizvod proizvod { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
