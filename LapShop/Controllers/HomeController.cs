using Microsoft.AspNetCore.Mvc;
using LapShop.Models;
using LapShop.Bl;

namespace LapShop.Controllers
{
    public class HomeController : Controller
    {
        IItems oClsItems;
        public HomeController(IItems item)
        {
            oClsItems = item;
        }
        public IActionResult Index()
        {
            VmHomePage vm = new VmHomePage();
            var allData = oClsItems.GetAllItemsData(null);
            vm.lstAllItems = allData.Take(18).ToList();
            vm.lstRecommendedItems = allData.Take(10).ToList();
            vm.lstNewItems = allData.Take(4).ToList();
            vm.lstFreeDeliveryItems = allData.Take(4).ToList();

            return View(vm);
        }
    }
}
