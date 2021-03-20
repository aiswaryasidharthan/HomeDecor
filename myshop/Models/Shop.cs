using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsOnSale { get; set; }
        public bool OnStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
