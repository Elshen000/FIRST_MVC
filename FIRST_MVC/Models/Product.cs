using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIRST_MVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public bool IsDeactive { get; set; }
        public int CategoryId { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
