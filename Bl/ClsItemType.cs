using LapShop.Models;
using Microsoft.EntityFrameworkCore;

namespace LapShop.Bl
{
    public interface IItemTypes
    {
        public List<TbItemType> GetAll();
        public TbItemType GetByID(int id);
        public bool Save(TbItemType itemType);
        public bool Delete(int id);
    }
    public class ClsItemType : IItemTypes
    {
        LapShopContext context;
        public ClsItemType(LapShopContext context)
        {
            this.context = context;
        }
        public List<TbItemType> GetAll()
        {
            try
            {
                var lstItemTypeTypes = context.TbItemTypes.Where(a => a.CurrentState == 1).ToList();
                return lstItemTypeTypes;
            }
            catch
            {
                return new List<TbItemType>();
            }
        }
        public TbItemType GetByID(int id)
        {
            try
            {
                var ItemType = context.TbItemTypes.FirstOrDefault(a => a.ItemTypeId == id && a.CurrentState == 1);
                return ItemType;
            }
            catch
            {
                return new TbItemType();
            }

        }
        public bool Save(TbItemType itemType)
        {

            try
            {
                if (itemType.ItemTypeId == 0)
                {
                    itemType.CreatedBy = "mo";
                    itemType.CreatedDate = DateTime.Now;
                    context.TbItemTypes.Add(itemType);
                }
                else
                {
                    itemType.UpdatedDate = DateTime.Now;
                    itemType.UpdatedBy = "ho";
                    context.Entry(itemType).State = EntityState.Modified;
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
                var itemType = GetByID(id);

                if (itemType == null)
                    return false;

                // logical delete, mark as deleted
                itemType.CurrentState = 0;
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