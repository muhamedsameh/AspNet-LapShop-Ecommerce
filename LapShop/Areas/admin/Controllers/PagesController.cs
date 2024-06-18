using Bl;
using Domains;
using LapShop.Bl;
using LapShop.Models;
using LapShop.Utlities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LapShop.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "Admin, data entry")]
    public class PagesController : Controller
    {
        IPages oClsPages { get; set; }
        public PagesController(IPages iPages)
        {
            oClsPages = iPages;
        }
        public IActionResult List()
        {
            return View(oClsPages.GetAll());
        }

        public IActionResult Edit(int? pageId)
        {
            var page = new TbPages();

            // edit not new
            if (pageId != null)
            {
                page = oClsPages.GetByID(Convert.ToInt32(pageId));
            };


            return View(page);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(TbPages page, List<IFormFile> Files)
        {

            if (!base.ModelState.IsValid)
            {
                return View("Edit", page);
            };

            // if img changed
            if (Files.Count > 0)
                page.ImgName = await Helper.UploadImage(Files, "Pages");

            oClsPages.Save(page);

            return RedirectToAction("List");
        }

        public IActionResult Delete(int? pageId)
        {
            oClsPages.Delete(Convert.ToInt32(pageId));
            return RedirectToAction("List");
        }
    }
}
