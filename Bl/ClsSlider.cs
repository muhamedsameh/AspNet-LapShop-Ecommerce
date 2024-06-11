using LapShop.Models;
using Microsoft.EntityFrameworkCore;

namespace LapShop.Bl
{
    public interface ISlider
    {
        public List<TbSlider> GetAll();
        public TbSlider GetByID(int id);
        public bool Save(TbSlider slider);
        public bool Delete(int id);
    }

    public class ClsSlider : ISlider
    {
        LapShopContext context;

        public ClsSlider(LapShopContext context)
        {
            this.context = context;
        }

        public List<TbSlider> GetAll()
        {
            try
            {
                var lstSliders = context.TbSliders
                    .Where(a => a.CurrentState == 1).ToList();
                return lstSliders;
            }
            catch
            {
                return new List<TbSlider>();
            }
        }
        public TbSlider GetByID(int id)
        {
            try
            {
                var slider = context.TbSliders.FirstOrDefault(a => a.SliderId == id && a.CurrentState == 1);
                return slider;
            }
            catch
            {
                return new TbSlider();
            }

        }
        public bool Save(TbSlider slider)
        {

            try
            {

                if (slider.SliderId == 0)
                {
                    slider.CreatedBy = "mo";
                    slider.CreatedDate = DateTime.Now;
                    context.TbSliders.Add(slider);
                }
                else
                {
                    slider.UpdatedDate = DateTime.Now;
                    slider.UpdatedBy = "Mo";
                    context.Entry(slider).State = EntityState.Modified;
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
                var slider = GetByID(id);

                if (slider == null)
                    return false;


                slider.CurrentState = 0;
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

