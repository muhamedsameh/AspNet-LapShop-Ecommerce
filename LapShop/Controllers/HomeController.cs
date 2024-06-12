using Microsoft.AspNetCore.Mvc;
using LapShop.Models;
using LapShop.Bl;

namespace LapShop.Controllers
{
    public class HomeController : Controller
    {
        IItems oClsItems;
        ISlider oClsSliders;
        ICategories oClsCategories;
        public HomeController(IItems item, ISlider slider, ICategories iCategories)
        {
            oClsItems = item;
            oClsSliders = slider;
            oClsCategories = iCategories;
        }
        public IActionResult Index()
        {
            VmHomePage vm = new VmHomePage();

            var allData = oClsItems.GetAllItemsData(null);
            vm.lstAllItems = allData.Take(18).ToList();
            vm.lstRecommendedItems = allData.Take(10).ToList();
            vm.lstNewItems = allData.Take(4).ToList();
            vm.lstFreeDeliveryItems = allData.Take(4).ToList();

            vm.lstSliderItems = oClsSliders.GetAll().Take(4).ToList();

            vm.lstCategories = oClsCategories.GetAll().Take(4).ToList();

            return View(vm);
        }
    }
}
