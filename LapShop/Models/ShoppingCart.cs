namespace LapShop.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            lstItems = new List<ShoppingCardItem>();
        }
        public List<ShoppingCardItem> lstItems { get; set; }
        public decimal Total { get; set; }
        public string PromoCode { get; set; }
    }
}
