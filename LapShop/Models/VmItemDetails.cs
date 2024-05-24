namespace LapShop.Models
{
    public class VmItemDetails
    {
        public VwItem Item { get; set; }
        public List<TbItemImage> lstItemImages { get; set; }
        public List<VwItem> lstRecommendedItems { get; set; }
        public VmItemDetails() 
        {
            Item = new VwItem();
            lstItemImages = new List<TbItemImage>();
            lstItemImages.Add(new TbItemImage());
        }
    }
}
