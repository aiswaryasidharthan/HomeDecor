using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models
{
    public class ShoppingCartItem
    {
        public string ShoppingCartId { get; set; }
        public int ShoppingCartItemId { get; set; }
        public Shop Shop { get; set; }
        public int Amount { get; set; }
    }
}
