using FIRST_MVC.DAL;
using FIRST_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIRST_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class CategoriesController : Controller
    {
        #region DbContext
        private readonly AppDbContext _db;
        public CategoriesController(AppDbContext db)
        {
            _db = db;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.Include(x => x.Products).ToList();
            return View(categories);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = _db.Categories.Any(x => x.Name == category.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This category is already exist !");
                return View();
            }
            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Category dbcategory = await _db.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (dbcategory == null)
            {
                return NotFound();
            }

            return View(dbcategory);
        }
        #endregion

        #region Update
        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();
            Category dbcategory = _db.Categories.FirstOrDefault(x => x.Id == id);
            if (dbcategory == null)
            {
                return NotFound();
            }
            return View(dbcategory);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Category category)
        {
            if (id == null)
                return NotFound();
            Category dbcategory = _db.Categories.FirstOrDefault(x => x.Id == id);
            if (dbcategory == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View(dbcategory);
            }
            bool isExist = _db.Categories.Any(x => x.Name == category.Name && x.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This category is already exist !");
                return View(dbcategory);
            }
            dbcategory.Name = category.Name;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            Category dbcategory = _db.Categories.FirstOrDefault(x => x.Id == id);
            if (dbcategory == null)
            {
                return NotFound();
            }
            return View(dbcategory);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePostAsync(int? id)
        {
            if (id == null)
                return NotFound();
            Category category = _db.Categories.FirstOrDefault(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            category.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion



    }
}
