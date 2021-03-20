using myshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Shop> productsonsale { get; set; }
    }
}
