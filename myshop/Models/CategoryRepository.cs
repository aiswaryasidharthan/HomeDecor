using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public IEnumerable<Category> GetCategories => _appDbContext.categories;
       // { 
           // new Category{Categoryid=1, CategoryName="wood", Categorydescription= "Cozy woody" },
           // new Category{Categoryid=2,CategoryName="RoseWood", Categorydescription="Elegant for living room"}
           // }
    }
}
