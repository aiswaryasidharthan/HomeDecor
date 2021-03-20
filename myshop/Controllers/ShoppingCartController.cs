using Microsoft.AspNetCore.Mvc;
using myshop.Models;
using myshop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Controllers
{
    public class ShoppingCartController:Controller
    {
        private readonly IShopRepository _shopRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IShopRepository shopRepository, ShoppingCart shoppingCart)

        {
            _shopRepository = shopRepository;
            _shoppingCart = shoppingCart;   

        }
        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int ShopId)
        {
            var selectedShop = _shopRepository.Getallproducts.FirstOrDefault(c => c.ShopId == ShopId);
            if (selectedShop != null)
            {
                _shoppingCart.AddToCart(selectedShop, 1);

            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int ShopId)
        {
            var selectedShop = _shopRepository.Getallproducts.FirstOrDefault(c => c.ShopId == ShopId);
            if (selectedShop != null)
            {
                _shoppingCart.RemoveFromCart(selectedShop);

            }
            return RedirectToAction("Index");
        }

    }
}
