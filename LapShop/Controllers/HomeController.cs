using Microsoft.AspNetCore.Mvc;
using LapShop.Models;
using LapShop.Bl;

namespace LapShop.Controllers
{
    public class HomeController : Controller
    {
        IItems oClsItems;
        ISlider oClsSliders;
        public HomeController(IItems item, ISlider slider)
        {
            oClsItems = item;
            oClsSliders = slider;

        }
        public IActionResult Index()
        {
            VmHomePage vm = new VmHomePage();
            var allData = oClsItems.GetAllItemsData(null);
            vm.lstAllItems = allData.Take(18).ToList();
            vm.lstRecommendedItems = allData.Take(10).ToList();
            vm.lstNewItems = allData.Take(4).ToList();
            vm.lstFreeDeliveryItems = allData.Take(4).ToList();

            var sliders = oClsSliders.GetAll().Take(4).ToList();
            vm.lstSliderItems = sliders;

            return View(vm);
        }
    }
}
