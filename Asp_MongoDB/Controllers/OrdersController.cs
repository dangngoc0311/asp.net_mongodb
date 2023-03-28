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
    public class OrdersController : Controller
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

        public OrdersController(IToastNotification toastrNotification, IOptions<Settings> settings)
        {
            _context = new Asp_MongoDBContext(settings);
            _toastNotification = toastrNotification;
        }
       
        public IActionResult Create()
        {
            ViewBag.Carts = listCarts;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Order order)
        {
            ViewBag.Carts = listCarts;
            double total=0;
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (var item in listCarts)
            {
                OrderItem o = new OrderItem
                {
                    BookId = new  MongoDB.Bson.ObjectId(item.BookId),
                    Quantity = item.Quantity,
                    Price = item.Price
                };
                total += o.Price * o.Quantity;
                orderItems.Add(o);
            }
            // Create a new order with the order item
            bool v = order.Note == "";
            var orders = new Order
            {
                FullName = order.FullName,
                CreatedAt = DateTime.Now,
                Address = order.Address,
                ContactNumber = order.ContactNumber,
                EmailAddress = order.EmailAddress,
                Note = order.Note ?? "",
                Price = total,
                OrderItems = orderItems
            };

            // Insert the order into the database
            await _context.Order.InsertOneAsync(orders);

            // Update the book quantity in the database
            //book.Quantity -= quantity;
            //await _context.Books.ReplaceOneAsync(x => x.BookId == book.BookId, book);
            //foreach (var item in listCarts)
            //    {
            //        OrderItem o = new OrderItem
            //        {
            //            PriceUnit = item.UnitPrice,
            //            Quantity = item.Quantity,
            //            UnitId = item.UnitId,
            //            OrderId = order.OrderId
            //        };
            //        _context.Add(o);
            //        await _context.SaveChangesAsync();
            //    }
               
                HttpContext.Session.Remove("ShoppingCart");
                _toastNotification.AddSuccessToastMessage("Order successfully!! Please check your mail");
                return RedirectToAction("Details", new { id = orders.OrderId });
            
        }
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = _context.Order.Find(Builders<Order>.Filter.Eq("OrderId", id)).FirstOrDefault();
            if (order == null)
            {
                return NotFound();
            }
            var orderItems = new List<OrderItem>();
            foreach (var item in order.OrderItems)
            {
                var book =  _context.Book.Find(c => c.BookId == item.BookId.ToString()).FirstOrDefault();
                var or = new OrderItem
                {
                    BookId = item.BookId,
                    Quantity = item.Quantity,
                    Price = item.Price,
                    BookName = book.BookName,
                    Image = book.Image
                };
                orderItems.Add(or);
            }
            ViewBag.OrderItems = orderItems;
            return View(order);
        }

    }
}
