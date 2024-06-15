using Bl;
using Microsoft.AspNetCore.Mvc;

namespace LapShop.Controllers
{
    public class PagesController : Controller
    {
        IPages oClsPages;
        public PagesController(IPages iPages)
        {
            oClsPages = iPages;
        }
        public IActionResult Index(int id)
        {
            var page = oClsPages.GetByID(id);
            return View(page);
        }
    }
}
