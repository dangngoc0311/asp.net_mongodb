using Asp_MongoDB.Data;
using Asp_MongoDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_MongoDB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        private readonly Asp_MongoDBContext _context = null;

        public OrdersController(IOptions<Settings> settings)
        {
            _context = new Asp_MongoDBContext(settings);
        }
        public async Task<IActionResult> Index(int? page, string name)
        {
            page = page ?? 1;
            var pageSize = 4;
            var filter = Builders<Order>.Filter.Empty;

            if (!string.IsNullOrEmpty(name))
            {
                filter = Builders<Order>.Filter.Where(x => x.FullName.Contains(name) || x.EmailAddress.Contains(name));
            }
            var order = await _context.Order
               .Find(filter).Skip((page - 1) * pageSize).Limit(pageSize).ToListAsync();

            ViewBag.TotalPages = Math.Ceiling((decimal)await _context.Order.CountDocumentsAsync(filter) / pageSize);
            ViewBag.CurrentPage = page;
            ViewBag.SearchTerm = name;
            return View(order);
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
                var book = _context.Book.Find(c => c.BookId == item.BookId.ToString()).FirstOrDefault();
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
