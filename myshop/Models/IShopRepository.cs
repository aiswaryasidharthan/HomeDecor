using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models
{
    public interface IShopRepository
    {
        IEnumerable<Shop> Getallproducts { get; }
        IEnumerable<Shop> Getproductsonsale { get; }
        // Shop GetShopById (int ShopId);
        Shop GetShopById(int ShopId);
    }
}
