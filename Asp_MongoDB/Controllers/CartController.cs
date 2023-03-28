using Asp_MongoDB.Data;
using Asp_MongoDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Newtonsoft.Json;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_MongoDB.Controllers
{
    public class CartController : Controller
    {
        private readonly IToastNotification _toastNotification;
        private List<Cart> listCarts = new List<Cart>();
        private readonly Asp_MongoDBContext _context = null;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cartInSession = HttpContext.Session.GetString("ShoppingCart");
            if (cartInSession != null)
            {
                listCarts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }

            base.OnActionExecuting(context);
        }

        public CartController(IToastNotification toastrNotification, IOptions<Settings> settings)
        {
            _context = new Asp_MongoDBContext(settings);
            _toastNotification = toastrNotification;
        }
        public IActionResult Index()
        {
            return View(listCarts);
        }
        public IActionResult AddCart(string id,int? qty)
        {
            qty = qty ?? 1;
            if (listCarts.Any(c => c.BookId == id))
            {
                listCarts.Where(c => c.BookId == id).First().Quantity += (int)qty;
            }
            else
            {
                var book = _context.Book.Find(c => c.BookId == id).FirstOrDefault();
                var cart = new Cart()
                {
                    BookId = book.BookId,
                    BookName = book.BookName,
                    Image = book.Image,
                    Price = book.Price,
                    Quantity = (int)qty
                };
                listCarts.Add(cart);
            }
            HttpContext.Session.SetString("ShoppingCart", JsonConvert.SerializeObject(listCarts));
            _toastNotification.AddSuccessToastMessage("Add cart successfully");
            return RedirectToAction(nameof(Index));
        }
        public IActionResult RemoveItemCart(string id)
        {
            if (listCarts.Any(c => c.BookId == id))
            {
                var remove = listCarts.Where(c => c.BookId == id).First();
                listCarts.Remove(remove);
                HttpContext.Session.SetString("ShoppingCart", JsonConvert.SerializeObject(listCarts));
                _toastNotification.AddSuccessToastMessage("Remove item successfully");
            }
            return RedirectToAction(nameof(Index));
        }
        public ActionResult IncreaseQtyCart(string id)
        {
          
            if (listCarts.Any(c => c.BookId == id))
            {
                listCarts.Where(c => c.BookId == id).First().Quantity += 1;
                HttpContext.Session.SetString("ShoppingCart", JsonConvert.SerializeObject(listCarts));
                _toastNotification.AddSuccessToastMessage("Update cart successfully");
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult DecreaseQtyCart(string id)
        {
            if (listCarts.Any(c => c.BookId == id))
            {
                var cart = listCarts.Where(c => c.BookId == id).First();
                if (cart.Quantity <= 1)
                {
                    cart.Quantity = 1;
                }
                else
                {
                    cart.Quantity -= 1;
                }
                HttpContext.Session.SetString("ShoppingCart", JsonConvert.SerializeObject(listCarts));
                _toastNotification.AddSuccessToastMessage("Update cart successfully");
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Clear()
        {
            HttpContext.Session.Remove("ShoppingCart");
            HttpContext.Session.Remove("Coupon");
            _toastNotification.AddSuccessToastMessage("Clear cart successfully");
            return RedirectToAction(nameof(Index));
        }
        
    }
}
