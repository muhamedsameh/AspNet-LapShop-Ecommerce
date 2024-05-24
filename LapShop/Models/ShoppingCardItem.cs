namespace LapShop.Models
{
    public class ShoppingCardItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ImageName { get; set; }
        public decimal ItemPrice { get; set; }
        public int ItemQty { get; set; }
        public decimal Total { get; set; }
    }
}
