using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIRST_MVC.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string  Title { get; set; }
        public string SubTitle { get; set; }
        public DateTime Date { get; set; }
    }
}
