using Microsoft.AspNetCore.Mvc;
using myshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Components
{
    public class Menu: ViewComponent 
    {
        private readonly ICategoryRepository _categoryRepository;
            public Menu(ICategoryRepository categoryRepository)
        {
            _categoryRepository =  categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
