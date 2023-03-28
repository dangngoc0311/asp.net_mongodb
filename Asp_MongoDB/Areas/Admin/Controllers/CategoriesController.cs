using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Asp_MongoDB.Data;
using Asp_MongoDB.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;
using NToastNotify;
using System;

namespace Asp_MongoDB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly Asp_MongoDBContext _context = null;
        private readonly IToastNotification _toastNotification;
        public CategoriesController(IOptions<Settings> settings, IToastNotification toastrNotification)
        {
            _context = new Asp_MongoDBContext(settings);
            _toastNotification = toastrNotification;
        }

        // GET: Admin/Categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Category.Find(x=>true).ToListAsync());
        }

        // GET: Admin/Categories/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category =  Builders<Category>.Filter.Eq("CategoryId", id);
            if (category == null)
            {
                return NotFound();
            }

            return View(await _context.Category.Find(category).FirstOrDefaultAsync());
        }

        // GET: Admin/Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _context.Category.InsertOneAsync(category);
                    _toastNotification.AddSuccessToastMessage("Create new category successfully");
                }
                catch (System.Exception)
                {
                    _toastNotification.AddErrorToastMessage("Create new category failed");
                    return View(category);
                }
                
            }
                return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Categories/Edit/5
        public async Task<IActionResult> Edit(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var category = Builders<Category>.Filter.Eq("CategoryId", id);
            if (category == null)
            {
                return NotFound();
            }

            return View(await _context.Category.Find(category).FirstOrDefaultAsync());
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.Category.ReplaceOneAsync(zz=>zz.CategoryId==id,category);
                    _toastNotification.AddSuccessToastMessage("Update successfully");
                }
                catch (DbUpdateConcurrencyException)
                {
                    _toastNotification.AddErrorToastMessage("Update failed");
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // Get: Admin/Categories/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
           
            try
            {
                var category = _context.Category.Find(Builders<Category>.Filter.Eq("CategoryId", id)).FirstOrDefault();
                var books = await _context.Book.CountDocumentsAsync(x => x.Category == new ObjectId(category.CategoryId));
                if (books > 0)
                {
                    _toastNotification.AddErrorToastMessage("Category cannot be deleted because it has associated books.");
                }

                else
                {
                    await _context.Category.DeleteOneAsync(Builders<Category>.Filter.Eq("CategoryId", id));
                    _toastNotification.AddSuccessToastMessage("Delete successfully");
                }
            }
            catch (Exception)
            {
                _toastNotification.AddErrorToastMessage("Delete failed");
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/Categories/DeleteAll
        //[HttpPost, ActionName("DeleteAll")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteAll()
        //{
        //    var category = await _context.Category.DeleteManyAsync(new BsonDocument());

        //    return RedirectToAction(nameof(Index));
        //}

    }
}
