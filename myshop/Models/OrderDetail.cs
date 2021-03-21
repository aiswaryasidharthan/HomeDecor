using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int OrderDetailId { get; set; }
        public int ShopId { get; set; }
        public int Amount { get; set; }
        public Shop Shop { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }
    }
}
