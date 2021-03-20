using Microsoft.AspNetCore.Mvc;
using myshop.Models;
using myshop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShopRepository _shopRepository;
        public HomeController(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                productsonsale = _shopRepository.Getproductsonsale
            };
            return View(homeViewModel);
        }
    }
}
