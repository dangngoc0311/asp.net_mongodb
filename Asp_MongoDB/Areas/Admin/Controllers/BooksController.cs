using Asp_MongoDB.Data;
using Asp_MongoDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using NToastNotify;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_MongoDB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {

        private readonly Asp_MongoDBContext _context = null;
        private readonly IToastNotification _toastNotification;
        public BooksController(IOptions<Settings> settings, IToastNotification toastrNotification)
        {
            _context = new Asp_MongoDBContext(settings);
            _toastNotification = toastrNotification;
        }
        // GET: BooksController
        public async Task<ActionResult> Index(int ?  page, string name)
        {
            page = page ?? 1;
            var pageSize = 2;

            //var books = await _context.Book.Aggregate()
            //    .Lookup(_context.Category,
            //            b => b.Category,
            //            c => c.CategoryId,
            //            (Book p) => p.Category)
            //    .Unwind(x => x.Category, new AggregateUnwindOptions<Book>() { PreserveNullAndEmptyArrays = true })
            //    .Project(x => new Book
            //    {
            //        BookId = x.BookId,
            //        BookName=x.BookName,
            //        Author = x.Author,
            //        Description=x.Description,
            //        Image = x.Image,
            //        Price=x.Price,
            //        Quantity = x.Quantity,
            //        Category = x.Category,
            //        CategoryName = "$Category.CategoryName"
            //    })
            //    .ToListAsync();

            var filter = Builders<Book>.Filter.Empty;

            if (!string.IsNullOrEmpty(name))
            {
                filter = Builders<Book>.Filter.Where(x => x.BookName.Contains(name));
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
            ViewBag.SearchTerm = name;
            return View(books);
        }

        // GET: BooksController/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = Builders<Book>.Filter.Eq("BookId", id);
            if (book == null)
            {
                return NotFound();
            }

            return View(await _context.Book.Find(book).FirstOrDefaultAsync());
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            ViewData["Category"] = new SelectList(_context.Category.Find(x => true).ToList(), "CategoryId", "CategoryName"); 
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Book book,string cate)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                   
                    var file = files[0];
                    var FileName = file.FileName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\books", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        book.Image = FileName;
                    }

                }
                book.Category = new ObjectId(cate);
                await _context.Book.InsertOneAsync(book);
                _toastNotification.AddSuccessToastMessage("Create new book successfully");
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: BooksController/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            ViewData["Category"] = _context.Category.Find(x => true).ToList();
            if (id == null)
            {
                return NotFound();
            }

            var book = Builders<Book>.Filter.Eq("BookId", id);
            if (book == null)
            {
                return NotFound();
            }

            return View(await _context.Book.Find(book).FirstOrDefaultAsync());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Book book, string img, string cate)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var files = HttpContext.Request.Form.Files;
                    if (files.Count() > 0 && files[0].Length > 0)
                    {
                        var file = files[0];
                        var FileName = file.FileName;
                        if (book.Image != null)
                        {
                            string oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\books", book.Image);
                            if (System.IO.File.Exists(oldImagePath))
                            {
                                System.IO.File.Delete(oldImagePath);
                            }
                        }
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\books", FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            book.Image = FileName;
                        }
                    }
                    else
                    {
                        book.Image = img;
                    }
                    book.Category = new ObjectId(cate);
               
                    await _context.Book.ReplaceOneAsync(zz => zz.BookId == id, book);
                    _toastNotification.AddSuccessToastMessage("Update successfully");
                }
                catch (DbUpdateConcurrencyException)
                {
                    _toastNotification.AddErrorToastMessage("Update failed");
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }


        // GET: BooksController/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            try
            {

                var ordersWithBook = await _context.Order
                   .Find(o => o.OrderItems.Any(oi => oi.BookId == new ObjectId(id)))
                   .ToListAsync();
                if (ordersWithBook.Any())
                {
                    _toastNotification.AddErrorToastMessage("Cannot delete the book because it has orders associated with it");
                }
                else
                {
                    var book = _context.Book.Find(Builders<Book>.Filter.Eq("BookId", id)).FirstOrDefault();
                    if (book.Image != null)
                    {
                        string oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\books", book.Image);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    await _context.Book.DeleteOneAsync(Builders<Book>.Filter.Eq("BookId", id));

                    _toastNotification.AddSuccessToastMessage("Delete successfully");
                }
            }
            catch (Exception)
            {
                _toastNotification.AddErrorToastMessage("Delete failed");
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
