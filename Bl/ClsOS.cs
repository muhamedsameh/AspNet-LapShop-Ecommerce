using LapShop.Models;
using Microsoft.EntityFrameworkCore;

namespace LapShop.Bl
{
    public interface IOS
    {
        public List<TbO> GetAll();
        public TbO GetByID(int id);
        public bool Save(TbO os);
        public bool Delete(int id);
    }
    public class ClsOS : IOS
    {
        LapShopContext context;

        public ClsOS(LapShopContext context)
        {
            this.context = context;
        }
        public List<TbO> GetAll()
        {
            try
            {
                var lstOSs = context.TbOs.Where(a => a.CurrentState == 1).ToList();
                return lstOSs;
            }
            catch
            {
                return new List<TbO>();
            }
        }
        public TbO GetByID(int id)
        {
            try
            {

                var os = context.TbOs.FirstOrDefault(a => a.OsId == id && a.CurrentState == 1);
                return os;
            }
            catch
            {
                return new TbO();
            }

        }
        public bool Save(TbO os)
        {

            try
            {

                if (os.OsId == 0)
                {
                    os.CreatedBy = "mo";
                    os.CreatedDate = DateTime.Now;
                    context.TbOs.Add(os);
                }
                else
                {
                    os.UpdatedDate = DateTime.Now;
                    os.UpdatedBy = "ho";
                    context.Entry(os).State = EntityState.Modified;
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
                var os = GetByID(id);

                if (os == null)
                    return false;



                os.CurrentState = 0;
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

