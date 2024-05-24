using LapShop.Bl;
using LapShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LapShop.Controllers
{
    public class OrderController : Controller
    {
        IItems oClsItems;
        public OrderController(IItems iItem)
        {
            oClsItems = iItem;
        }
        public IActionResult MyOrders()
        {
            return View();
        }
        [Authorize]
        public IActionResult OrderSuccess()
        {
            return View();
        }
        public IActionResult Cart()
        {
            // get shopingCart object as string from cookies.
            var strCart = string.Empty;
            if (HttpContext.Request.Cookies["Cart"] != null)
                strCart = HttpContext.Request.Cookies["Cart"];

            // convert shoppingCart string to object again.
            var cart = JsonConvert.DeserializeObject<ShoppingCart>(strCart);
            return View(cart);
        }
        public IActionResult AddToCart(int itemId)
        {
            // this funcion do this.
            // get data from session if exist.
            // update data with new item.
            // push data to session again.


             ShoppingCart ObjCart;
            var strCart = string.Empty;

            // check cookies is not null => we have data, get strCart from cookies.
            if (HttpContext.Request.Cookies["Cart"] != null)
            {
                // get strCart
                strCart = HttpContext.Request.Cookies["Cart"];

                // convert strCart => objCart
                ObjCart = JsonConvert.DeserializeObject<ShoppingCart>(strCart);

            }
            else // new cart
            {
                ObjCart = new ShoppingCart();
            }

            var existItem = ObjCart.lstItems.FirstOrDefault(a => a.ItemId == itemId);
           
            // exist, increment quantity++;
            if (existItem != null) 
            {
                existItem.ItemQty += 1;
                existItem.Total += existItem.ItemPrice;
            }
            else // add new item
            {
                // get the item
                var item = oClsItems.GetByID(itemId);

                ObjCart.lstItems.Add(new ShoppingCardItem
                {
                    //mapping: itm -> shoppingCartItem
                    ItemId = item.ItemId,
                    ItemName = item.ItemName,
                    ItemPrice = item.SalesPrice,
                    ImageName = item.ImageName,
                    ItemQty = 1,
                    Total = item.SalesPrice
                });
            }

            // convert whole objCart => strCart,
            strCart = JsonConvert.SerializeObject(ObjCart);

            // add strCart to the cookies
            HttpContext.Response.Cookies.Append("Cart", strCart);

            // after redirect, data woul be accessable any page, in cookies
            return RedirectToAction("Cart");
        }
    }
}
