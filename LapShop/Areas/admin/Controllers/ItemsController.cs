
using LapShop.Models;
using Microsoft.AspNetCore.Mvc;
using LapShop.Utlities;
using LapShop.Bl;
using Microsoft.AspNetCore.Authorization;

namespace LapShop.Areas.admin.Controllers
{
    [Authorize(Roles = "Admin, data entry")]
    [Area("admin")]
    public class ItemsController : Controller
    {
        IOS oClsOS;
        IItems oClsItems;
        IItemTypes oClsItemType;
        ICategories oClsCategories;

        public ItemsController(IOS os, IItems item, IItemTypes itemType, ICategories category)
        {
            oClsOS = os;
            oClsItems = item;
            oClsItemType = itemType;
            oClsCategories = category;
        }

        public IActionResult List()
        {
            ViewBag.lstCategories = oClsCategories.GetAll();
            return View(oClsItems.GetAllItemsData(null));
        }

        public IActionResult Search(int id)
        {
            ViewBag.lstCategories = oClsCategories.GetAll();
            var items = oClsItems.GetAllItemsData(id);
            return View("List", items);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int? itemId)
        {
            var item = new TbItem();

            if (itemId != null)
                item = oClsItems.GetByID(Convert.ToInt32(itemId));
            // id is null => new item (send empty model), id exist => edit item (send selected item model)

            // send list of categories, types, OS.
            ViewBag.lstCategories = oClsCategories.GetAll();
            ViewBag.lstTypes = oClsItemType.GetAll();
            ViewBag.lstOS = oClsOS.GetAll();

            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(TbItem item, List<IFormFile> Files)
        {
            if (!base.ModelState.IsValid)
            {
                return View("Edit", item);
            }

            item.ImageName = await Helper.UploadImage(Files, "Items");
            oClsItems.Save(item);

            return RedirectToAction("Edit");
        }

        public IActionResult Delete(int itemId)
        {
            oClsItems.Delete(Convert.ToInt32(itemId));
            return RedirectToAction("List");
        }

    }
}
