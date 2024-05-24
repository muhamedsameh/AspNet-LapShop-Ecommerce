using LapShop.Models;
using Microsoft.EntityFrameworkCore;

namespace LapShop.Bl
{
    public interface IItems
    {
        public List<TbItem> GetAll();
        public List<VwItem> GetAllItemsData(int? categoryId);
        public List<VwItem> GetRecommendedItems(int itemId);
        public TbItem GetByID(int id);
        public bool Save(TbItem item);
        public bool Delete(int id);
        public VwItem GetItemByID(int id);
    }
    public class ClsItems : IItems
    {
        // cls item depends on LapShopContext class.
        LapShopContext context;
        public ClsItems(LapShopContext context)
        {
            this.context = context;
        }

        public List<TbItem> GetAll()
        {
            try
            {
                var lstItems = context.TbItems.Where(a => a.CurrentState == 1).ToList();
                return lstItems;
            }
            catch
            {
                return new List<TbItem>();
            }
        }
        public List<VwItem> GetAllItemsData(int? categoryId)
        {
            try
            {

                var lstItems = context.VwItems
                    .Where(a => (a.CategoryId == categoryId  || categoryId == null  || categoryId == 0)  && a.CurrentState == 1 )
                    .OrderByDescending(a => a.CreatedDate)
                    .ToList();
                return lstItems;
            }
            catch
            {
                return new List<VwItem>();
            }
        }

        public TbItem GetByID(int id)
        {
            try
            {
                var item = context.TbItems.FirstOrDefault(a => a.ItemId == id && a.CurrentState == 1);
                return item;
            }
            catch
            {
                return new TbItem();
            }
        }

        public VwItem GetItemByID(int id)
        {
            try
            {
                var item = context.VwItems.FirstOrDefault(a => a.ItemId == id && a.CurrentState == 1);
                return item;
            }
            catch
            {
                return new VwItem();
            }
        }
        public bool Save(TbItem item)
        {
            try
            {
                if (item.ItemId == 0)
                {
                    item.CreatedBy = "mo";
                    item.CreatedDate = DateTime.Now;
                    item.CurrentState = 1;
                    context.TbItems.Add(item);
                }
                else
                {
                    item.UpdatedDate = DateTime.Now;
                    item.UpdatedBy = "ho";
                    context.Entry(item).State = EntityState.Modified;
                }
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                var item = GetByID(id);

                if (item == null)
                    return false;

                item.CurrentState = 0;
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<VwItem> GetRecommendedItems(int itemId)
        {
            try
            {
                var item = GetByID(itemId);
                var lstItems = context.VwItems
                    .Where(a => a.SalesPrice > item.SalesPrice - 50
                               && a.SalesPrice < item.SalesPrice + 50
                               && a.CurrentState == 1)
                    .OrderByDescending(a => a.CreatedDate)
                    .ToList();
                return lstItems;
            }
            catch
            {
                return new List<VwItem>();
            }
        }
    }
}
