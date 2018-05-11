using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IAstronomicalObjectRepository _astronomicalObjectRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IAstronomicalObjectRepository astronomicalObjectRepository, ShoppingCart shoppingCart)
        {
            _astronomicalObjectRepository = astronomicalObjectRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int astronomicalObjectId)
        {
            var selectedAstronomicalObject = _astronomicalObjectRepository.AstronomicalObjects.FirstOrDefault(p => p.AstronomicalObjectId == astronomicalObjectId);
            if (selectedAstronomicalObject != null)
            {
                _shoppingCart.AddToCart(selectedAstronomicalObject, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int astronomicalObjectId)
        {
            var selectedAstronomicalObject = _astronomicalObjectRepository.AstronomicalObjects.FirstOrDefault(p => p.AstronomicalObjectId == astronomicalObjectId);
            if (selectedAstronomicalObject != null)
            {
                _shoppingCart.RemoveFromCart(selectedAstronomicalObject);
            }
            return RedirectToAction("Index");
        }
    }
}
