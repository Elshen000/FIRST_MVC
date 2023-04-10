
using FIRST_MVC.DAL;
using FIRST_MVC.Models;
using FIRST_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FIRST_MVC.Controllers
{
    public class HomeController : Controller
    {
        #region DbContext
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
               
                SliderImage = _db.SliderImage.ToList(),
                Icon = _db.Icons.ToList(),
                Products = _db.Products.Include(x => x.Category).Where(x=>!x.IsDeactive).OrderByDescending(x => x.Id).Take(12).ToList(),
                Categories = _db.Categories.Where(x => !x.IsDeactive).ToList()
            };
            return View(homeVM);
        }
        #endregion

        #region Search
        public async Task<IActionResult> GlobalSearch(string keyword)
        {
            List<Product> products = await _db.Products.OrderByDescending(x => x.Id).Where(x => x.Name.Contains(keyword)&&!x.IsDeactive).Take(20).ToListAsync();
            return PartialView("_SearchedProductsPartial", products);
        }

        #endregion






    }
}
