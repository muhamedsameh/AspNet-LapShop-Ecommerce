using LapShop.Models;
using Microsoft.EntityFrameworkCore;

namespace LapShop.Bl
{
    public interface IItemImages
    {
        public List<TbItemImage> GetByItemId(int id);

    }
    public class ClsItemImages : IItemImages
    {
        // cls item depends on LapShopContext class.
        LapShopContext context;
        public ClsItemImages(LapShopContext context)
        {
            this.context = context;
        }


        public List<TbItemImage> GetByItemId(int id)
        {
            try
            {
                var item = context.TbItemImages.Where(a => a.ItemId == id).ToList();
                return item;
            }
            catch
            {
                return new List<TbItemImage>();
            }
        }

        
    }
}
