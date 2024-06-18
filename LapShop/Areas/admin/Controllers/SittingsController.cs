using Domains;
using LapShop.Bl;
using LapShop.Models;
using LapShop.Utlities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LapShop.Areas.admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("admin")]
    public class SittingsController : Controller
    {
        ISittings oClsSittings;
        public SittingsController(ISittings iSittings)
        {
            oClsSittings = iSittings;
        }

        public IActionResult Edit()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(TbSittings sittings, List<IFormFile> logoFile, List<IFormFile> middlePannerFile, List<IFormFile> lastPannerFile, List<IFormFile> homeBackgroundFile)
        {

            if (!base.ModelState.IsValid)
            {
                return View("Edit", sittings);
            }

            // update files
            sittings.Logo = await Helper.UploadImage(logoFile, "Sittings");
            sittings.MiddlePanner = await Helper.UploadImage(middlePannerFile, "Sittings");
            sittings.LastPanner = await Helper.UploadImage(lastPannerFile, "Sittings");
            sittings.HomeBackgroundImgName = await Helper.UploadImage(homeBackgroundFile, "Sittings");
            
            oClsSittings.Save(sittings);

            return RedirectToAction("Edit");
        }
    }
}
