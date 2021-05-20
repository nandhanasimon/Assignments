using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartDemo.Models;

namespace ShoppingCartDemo.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCart cart)
        {
            this.productRepository = productRepository;
            this.shoppingCart = cart;
        }
        public IActionResult Index()
        {
            shoppingCart.ShoppingCartItems = shoppingCart.GetShoppingCartItems();

            return View(shoppingCart);
        }
        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = productRepository.GetProductById(productId);
            shoppingCart.AddItemToCart(selectedProduct, selectedProduct.Price);
            
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = productRepository.GetProductById(productId);
            shoppingCart.RemoveItemFromCart(selectedProduct);
            return RedirectToAction("Index");
        }
    }
}
