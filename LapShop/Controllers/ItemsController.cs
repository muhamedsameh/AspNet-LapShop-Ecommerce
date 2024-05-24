using LapShop.Bl;
using LapShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace LapShop.Controllers
{
    public class ItemsController : Controller
    {
        IItems oClsItems;
        IItemImages oClsItemImages;
        public ItemsController(IItems iItem, IItemImages itemImages)
        {
            oClsItems = iItem;
            oClsItemImages = itemImages;
        }
        public IActionResult ItemDetails(int id)
        {
            VmItemDetails vm = new VmItemDetails();
            vm.Item = oClsItems.GetItemByID(id);
            vm.lstRecommendedItems = oClsItems.GetRecommendedItems(id).Take(6).ToList();
            vm.lstItemImages = oClsItemImages.GetByItemId(id);

            return View(vm);
        }
        public IActionResult ItemList()
        {
            return View();
        }
    }
}
