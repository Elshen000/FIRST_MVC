using FIRST_MVC.DAL;
using FIRST_MVC.Extensions;
using FIRST_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FIRST_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        #region DbContext
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index(int page = 1)
        {
            ViewBag.ProductsCount = _db.Products.Count();
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Products.Count() / 8);
            ViewBag.SelectedPage = page;
            List<Product> product = await _db.Products.Where(x => !x.IsDeactive).Include(x => x.Category).OrderByDescending(x => x.Id).Skip((page - 1) * 8).Take(8).ToListAsync();
            return View(product);
        }
        #endregion

        #region Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product, int catId)
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(product);
            }
            bool isExist = _db.Products.Any(x => x.Name == product.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Product is already exist !");
                return View(product);
            }
            if (product.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please Select Image");
                return View(product);
            }
            if (!product.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please Select Image");
                return View(product);
            }
            if (!product.Photo.IsLower4Mb())
            {
                ModelState.AddModelError("Photo", "Please Select Image Max 4mb");
                return View(product);
            }
            string folder = Path.Combine(_env.WebRootPath, "img");
            product.Image = await product.Photo.SaveFileAsync(folder);
            product.CategoryId = catId;
            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            Product product = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
                return NotFound();
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteAsync(int? id)
        {
            if (id == null)
                return NotFound();
            Product products = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (products == null)
            {
                return NotFound();
            }
            string path = Path.Combine(_env.WebRootPath, "img", products.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            products.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        #endregion

        #region Detail
        public async Task<IActionResult> DetailAsync(int? id)
        {
            if (id == null)
                return NotFound();
            Product product = await _db.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        #endregion

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();
            if (id == null)
                return NotFound();
            Product dbProduct = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (dbProduct == null)
                return BadRequest();
            return View(dbProduct);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Product product, int catId)
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();
            if (id == null)
                return NotFound();
            Product dbProduct = await _db.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
            if (dbProduct == null)
                return BadRequest();
            bool isExist = _db.Products.Any(x => x.Name == product.Name && x.Id != id);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Product is already exist !");
                return View(dbProduct);
            }
            if (product.Photo != null)
            {
                if (!product.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please Select Image");
                    return View(dbProduct);
                }
                if (!product.Photo.IsLower4Mb())
                {
                    ModelState.AddModelError("Photo", "Please Select Image Max 4Mb");
                    return View(dbProduct);

                }
                string folder = Path.Combine(_env.WebRootPath, "img");
                dbProduct.Image = await product.Photo.SaveFileAsync(folder);
            }
            dbProduct.Name = product.Name;
            dbProduct.Price = product.Price;
            dbProduct.CategoryId = catId;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion





    }
   
}
