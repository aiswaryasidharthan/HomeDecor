using Microsoft.AspNetCore.Mvc;
using myshop.Models;
using myshop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Controllers
{
    public class ShopController :Controller

    {
        private readonly IShopRepository _shopRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ShopController(IShopRepository shopRepository, ICategoryRepository categoryRepository)
        {
            _shopRepository = shopRepository;
            _categoryRepository = categoryRepository;

        }

        // Returning as list//
        //public IActionResult List()
        //{
        //    // ViewBag.current = "Best seller";
        //    //return View(_shopRepository.Getallproducts);

        //    var shopListViewModel = new ShopListViewModel();
        //    shopListViewModel.Products = _shopRepository.Getallproducts;
        //    shopListViewModel.current = "Best sellers";
        //    return View(shopListViewModel);
        //}

     
        //For Dropdown view//
        public ViewResult List(string category)
        {
            IEnumerable<Shop> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _shopRepository.Getallproducts.OrderBy(c => c.CategoryId);
                currentCategory = "All Products";
            }
            else
            {
                products = _shopRepository.Getallproducts.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ShopListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var shop = _shopRepository.GetShopById(id);
            if (shop == null)
                return NotFound();
            return View(shop);



        }
            
          

    }
    
}
