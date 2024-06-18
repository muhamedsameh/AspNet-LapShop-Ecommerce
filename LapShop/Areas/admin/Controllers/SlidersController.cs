using LapShop.Bl;
using LapShop.Models;
using LapShop.Utlities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LapShop.Areas.admin.Controllers
{
    [Authorize(Roles = "Admin, data entry")]
    [Area("admin")]
    public class SlidersController : Controller
    {
        ISlider oClsSlider;
        public SlidersController(ISlider iSlider)
        {
            oClsSlider = iSlider;
        }

        public IActionResult List()
        {
            return View(oClsSlider.GetAll());
        }
        public IActionResult Edit(int? sliderId)
        {
            var slider = new TbSlider();

            // edit not new
            if(sliderId != null)
            {
                slider = oClsSlider.GetByID(Convert.ToInt32(sliderId));
            };


            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(TbSlider slider, List<IFormFile> Files)
        {
            
            if (!base.ModelState.IsValid)
            {
                return View("Edit", slider);
            };

            // if img changed
            if(Files.Count> 0)
                slider.ImageName = await Helper.UploadImage(Files, "Sliders");
            
            oClsSlider.Save(slider);

            return RedirectToAction("List");
        }

        public IActionResult Delete(int? sliderId)
        {
            oClsSlider.Delete(Convert.ToInt32(sliderId));
            return RedirectToAction("List");
        }
    }
}
