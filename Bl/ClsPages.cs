using Domains;
using LapShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{

    public interface IPages
    {
        public List<TbPages> GetAll();
        public TbPages GetByID(int id);
        public bool Save(TbPages page);
        public bool Delete(int id);
    }
    public class ClsPages : IPages
    {
        LapShopContext context;

        public ClsPages(LapShopContext context)
        {
            this.context = context;
        }
        public List<TbPages> GetAll()
        {
            try
            {
                var lstPages = context.TbPages.Where(a => a.CurrentState == 1).ToList();
                return lstPages;
            }
            catch
            {
                return new List<TbPages>();
            }
        }
        public TbPages GetByID(int id)
        {
            try
            {
                var page = context.TbPages.FirstOrDefault(a => a.PageId == id && a.CurrentState == 1);
                return page;
            }
            catch
            {
                return new TbPages();
            }
        }
        public bool Save(TbPages page)
        {

            try
            {
                if (page.PageId == 0)
                {
                    page.CreatedBy = "Mo";
                    page.CreatedDate = DateTime.Now;
                    context.TbPages.Add(page);
                }
                else
                {
                    page.UpdatedDate = DateTime.Now;
                    page.UpdatedBy = "Mo";
                    context.Entry(page).State = EntityState.Modified;
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
                var page = GetByID(id);

                if (page == null)
                    return false;

                page.CurrentState = 0;
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
