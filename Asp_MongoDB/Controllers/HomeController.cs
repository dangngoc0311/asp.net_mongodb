using Asp_MongoDB.Data;
using Asp_MongoDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_MongoDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Asp_MongoDBContext _context = null;

        public HomeController(ILogger<HomeController> logger,IOptions<Settings> settings)
        {
            _logger = logger;
            _context = new Asp_MongoDBContext(settings);

        }

        public async Task<IActionResult> Index()
        {
            ViewData["Category"] = _context.Category.Find(x => true).ToList();
            var books = await _context.Book.Find(x => true).ToListAsync();
            foreach (var b in books)
            {
                var category = _context.Category.Find(c => c.CategoryId == b.Category.ToString()).FirstOrDefault();
                if (category != null)
                {
                    b.CategoryName = category.CategoryName;
                }
            }
            return View(books);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
