using Domains;

namespace LapShop.Models
{
    public class VmHomePage
    {
        public TbSittings TbSittings { get; set; }
        public List<VwItem> lstNewItems { get; set; }
        public List<VwItem> lstAllItems { get; set; }
        public List<TbSlider> lstSliderItems { get; set; }
        public List<TbCategory> lstCategories { get; set; }
        public List<VwItem> lstRecommendedItems { get; set; }
        public List<VwItem> lstFreeDeliveryItems { get; set; }
        
        public VmHomePage()
        {
            TbSittings = new TbSittings();
            lstNewItems = new List<VwItem>();
            lstAllItems = new List<VwItem>();
            lstSliderItems = new List<TbSlider>();
            lstCategories = new List<TbCategory>();
            lstRecommendedItems = new List<VwItem>();
            lstFreeDeliveryItems = new List<VwItem>();
        }

    }
}
