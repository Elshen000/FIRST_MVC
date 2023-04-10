using FIRST_MVC.DAL;
using FIRST_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FIRST_MVC.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext db;
        public HeaderViewComponent(AppDbContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = await db.Bios.FirstOrDefaultAsync();
            return View(bio);
        }
    }
}
