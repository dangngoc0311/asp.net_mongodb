using Asp_MongoDB.Data;
using Asp_MongoDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Asp_MongoDB.Controllers
{
    public class BooksController : Controller
    {
        private readonly Asp_MongoDBContext _context = null;

        public BooksController(IOptions<Settings> settings)
        {
            _context = new Asp_MongoDBContext(settings);
        }
        public async Task<IActionResult> Index(int? page, string name, string cate)
        {
            ViewData["Category"] = _context.Category.Find(x => true).ToList();
            page = page ?? 1;
            int pageSize = 6;
            ViewBag.SearchTerm = name;
            ViewBag.Cate = cate;
            var filter = Builders<Book>.Filter.Empty;
            if (!string.IsNullOrEmpty(name) && string.IsNullOrEmpty(cate))
            {
                filter = Builders<Book>.Filter.Where(x => x.BookName.Contains(name));
            }
            if (!string.IsNullOrEmpty(cate) && string.IsNullOrEmpty(name))
            {
                filter &= Builders<Book>.Filter.Eq(x => x.Category, new ObjectId(cate));
            }

            if (!string.IsNullOrEmpty(cate) && !string.IsNullOrEmpty(name))
            {
                filter &= Builders<Book>.Filter.And(
                            Builders<Book>.Filter.Where(x => x.BookName.Contains(name)),
                            Builders<Book>.Filter.Eq(x => x.Category, new ObjectId(cate))
                    );
            }

            var books = await _context.Book
               .Find(filter).Skip((page - 1) * pageSize).Limit(pageSize).ToListAsync();
            foreach (var b in books)
            {
                var category = _context.Category.Find(c => c.CategoryId == b.Category.ToString()).FirstOrDefault();
                if (category != null)
                {
                    b.CategoryName = category.CategoryName;
                }
            }
            ViewBag.TotalPages = Math.Ceiling((decimal)await _context.Book.CountDocumentsAsync(filter) / pageSize);
            ViewBag.CurrentPage = page;
            return View(books);
        }


        // GET: BooksController/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = _context.Book.Find(Builders<Book>.Filter.Eq("BookId", id)).FirstOrDefault();
           
            if (book == null)
            {
                return NotFound();
            }
            var category = _context.Category.Find(c => c.CategoryId == book.Category.ToString()).FirstOrDefault();
            if (category != null)
            {
                book.CategoryName = category.CategoryName;
            }
            var books = _context.Book.Find(
                    Builders<Book>.Filter.And(
                            Builders<Book>.Filter.Eq("Category", book.Category),
                            Builders<Book>.Filter.Ne("BookId", book.BookId)
                    )
                ).Skip(0).Limit(4).ToList();
            ViewData["RelatedBook"] = books;
            return View( book);
        }
    }
}
