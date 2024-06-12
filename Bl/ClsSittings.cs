using Domains;
using LapShop.Models;
using Microsoft.EntityFrameworkCore;



namespace LapShop.Bl
{
    public interface ISittings
    {
        public List<TbSittings> GetAll();
        public bool Save(TbSittings sittings);
    }

    public class ClsSittings : ISittings
    {
        LapShopContext context;
        public ClsSittings(LapShopContext context)
        {
            this.context = context;
        }

        public List<TbSittings> GetAll()
        {
            try
            {
                // one record
                var lstSittings = context.TbSittings.ToList();
                return lstSittings;
            }
            catch
            {
                return new List<TbSittings>();
            }

        }

        public bool Save(TbSittings sittings)
        {

            try
            {
                sittings.UpdatedDate = DateTime.Now;
                sittings.UpdatedBy = "M";
                context.Entry(sittings).State = EntityState.Modified;

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
