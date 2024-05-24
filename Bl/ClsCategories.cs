using LapShop.Models;
using Microsoft.EntityFrameworkCore;

namespace LapShop.Bl
{
    public interface ICategories
    {
        public List<TbCategory> GetAll();
        public TbCategory GetByID(int id);
        public bool Save(TbCategory category);
        public bool Delete(int id);
    }

    public class ClsCategories : ICategories
    {
        LapShopContext context;
        public ClsCategories(LapShopContext context)
        {
            this.context = context;
        }

        public List<TbCategory> GetAll()
        {
            try
            {
                var lstCategories = context.TbCategories.Where(a => a.CurrentState == 1).ToList();
                return lstCategories;
            }
            catch
            {
                return new List<TbCategory>();
            }

        }
        public TbCategory GetByID(int id)
        {
            try
            {
                var category = context.TbCategories.FirstOrDefault(a => a.CategoryId == id && a.CurrentState == 1);
                return category;
            }
            catch
            {
                return new TbCategory();
            }

        }
        public bool Save(TbCategory category)
        {

            try
            {
                if (category.CategoryId == 0)
                {
                    category.CurrentState = 1;
                    category.CreatedBy = "mo";
                    category.CreatedDate = DateTime.Now;
                    context.TbCategories.Add(category);
                }
                else
                {
                    category.UpdatedDate = DateTime.Now;
                    category.UpdatedBy = "ho";
                    context.Entry(category).State = EntityState.Modified;
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
                var cat = GetByID(id);

                if (cat == null)
                    return false;

                cat.CurrentState = 0;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
