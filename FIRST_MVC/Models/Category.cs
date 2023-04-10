using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FIRST_MVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name can't be empty!")]
        public string Name { get; set; }
        public bool IsDeactive { get; set; }
        public List<Product> Products { get; set; }
    }
}
