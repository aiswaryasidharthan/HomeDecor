using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models
{
    public class ShopRepository : IShopRepository
    {
        private readonly AppDbContext _appDbContext;
        public ShopRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
 
        }
        //private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Shop> Getallproducts
        {
            get
            {
                return _appDbContext.Products.Include(s => s.Category);
            }
            //new Shop{ShopId=1, Name="Indian wood", Description ="This is a wood imported from indian teak forest, polished and hand made from kerala nad imported", Price=123.3M,
               // Category =_categoryRepository.GetCategories.ToList()[0],},

           // new Shop {ShopId=2,Name="Singapore wood", Description ="Imported singapore wood, sandal wood", Price=250.98M, Category=_categoryRepository.GetCategories.ToList()[1]}
        }

        public IEnumerable<Shop> Getproductsonsale 
        {
            get
            {
                return _appDbContext.Products.Include(s => s.Category).Where(p => p.IsOnSale);
            }
        }

        public Shop GetShopById(int ShopId)
        {
            return _appDbContext.Products.FirstOrDefault(s => s.ShopId == ShopId);
        }
    }
}
