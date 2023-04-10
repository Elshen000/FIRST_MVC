using FIRST_MVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIRST_MVC.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<SliderImage> SliderImage { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet <About>About { get; set; }
        public DbSet <Icon>Icons { get; set; }
        public DbSet<FlowerExpert> FlowerExperts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Bio>().HasData(
                new Bio { Id=1,Logo="logo.png",Linkedin= "https://www.linkedin.com/feed/",Facebook= "https://www.facebook.com/" }
                );
        }

    }
}
