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
    [Authorize(Roles = "Admin")]
    public class SliderImageController : Controller
    {

        #region DbContext
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public SliderImageController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        #endregion

        #region Index
        public async Task<IActionResult> Index()
        {
            List<SliderImage> sliderImages = await _db.SliderImage.ToListAsync();
            return View(sliderImages);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderImage sliderImage)
        {
            if (sliderImage.Photo == null)
            {
                ModelState.AddModelError("Photo", "Please Select Image");
                return View();
            }
            if (!sliderImage.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please Select Image");
                return View();
            }
            if (!sliderImage.Photo.IsLower4Mb())
            {
                ModelState.AddModelError("Photo", "Please Select Image Max 4mb");
                return View();
            }
            string folder = Path.Combine(_env.WebRootPath, "img");
            sliderImage.Image = await sliderImage.Photo.SaveFileAsync(folder);

            await _db.SliderImage.AddAsync(sliderImage);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            SliderImage sliderImage = await _db.SliderImage.FirstOrDefaultAsync(x => x.Id == id);
            if (sliderImage == null)
                return NotFound();
            string path = Path.Combine(_env.WebRootPath, "img", sliderImage.Image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _db.SliderImage.Remove(sliderImage);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

    }
}
