using Domains;
using LapShop.Models;
using Microsoft.EntityFrameworkCore;



namespace LapShop.Bl
{
    public interface ISittings
    {
        public TbSittings GetAll();
        public bool Save(TbSittings sittings);
    }

    public class ClsSittings : ISittings
    {
        LapShopContext context;
        public ClsSittings(LapShopContext context)
        {
            this.context = context;
        }

        public TbSittings GetAll()
        {
            try
            {
                // one record
                var Sittings = context.TbSittings.FirstOrDefault();
                return Sittings;
            }
            catch
            {
                return new TbSittings();
            }

        }

        public bool Save(TbSittings sittingsModel)
        {

            try
            {
                // get the (only one) sittings record
                var sittings = context.TbSittings.FirstOrDefault();

                // update
                sittings.WebsiteName = sittingsModel.WebsiteName;
                sittings.InstaLink = sittingsModel.InstaLink;
                sittings.FacebookLink = sittingsModel.FacebookLink;
                sittings.YoutubeLink = sittingsModel.YoutubeLink;
                sittings.LinkedinLink = sittingsModel.LinkedinLink;
                sittings.PhoneNumber = sittingsModel.PhoneNumber;
                sittings.XLink = sittingsModel.XLink;
                sittings.Description = sittingsModel.Description;
                sittings.Location  = sittingsModel.Location;
                sittings.Logo = sittingsModel.Logo;
                sittings.MiddlePanner = sittingsModel.MiddlePanner;
                sittings.LastPanner  = sittingsModel.LastPanner;
                sittings.HomeBackgroundImgName = sittingsModel.HomeBackgroundImgName;
                sittings.Email  = sittingsModel.Email;

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
