using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models
{
    public class Category
    {
        public int Categoryid { get; set; }
        public string CategoryName { get; set; }
        public string Categorydescription { get; set; }
        public List <Shop> Products { get; set; }
    }
}
