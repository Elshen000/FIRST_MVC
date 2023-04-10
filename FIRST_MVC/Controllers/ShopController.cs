using FIRST_MVC.DAL;
using FIRST_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIRST_MVC.Controllers
{
    public class ShopController : Controller
    {
        #region DbContext
        private readonly AppDbContext _db;
        public ShopController(AppDbContext db)
        {
            _db = db;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            ViewBag.ProductsCount = _db.Products.Count();
            List<Product> products = _db.Products.OrderByDescending(x => x.Id).Take(8).ToList();
            return View(products);
        }
        #endregion

        #region LoadMore
        public IActionResult LoadMore(int skip)
        {
            if (skip > _db.Products.Count())
            {
                return Content("Get redd ol burdan");
            }
            List<Product> products = _db.Products.OrderByDescending(x => x.Id).Skip(skip).Take(8).ToList();
            return PartialView("_ProductsPartial", products);
        }
        #endregion

        #region Detail
        public async Task<IActionResult> Detail(int? id)
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



    }
}
