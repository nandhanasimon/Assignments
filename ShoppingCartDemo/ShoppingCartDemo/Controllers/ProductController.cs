using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartDemo.Models;
using ShoppingCartDemo.ViewModels;



namespace ShoppingCartDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IProductRepository productRepository;
        
        public ProductController(IProductRepository productRepository,ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
            this.productRepository = productRepository;

        }
       /* public IActionResult Index()
        {
            return View();
        }*/
       public ViewResult List()
        {
            /* ViewBag.SelectedCategory = categoryRepository.AllCategories.ToList()[2].Name; 
             return View(productRepository.AllProducts);*/

            ProductListVM productListVM = new ProductListVM()
            {
                Products = productRepository.AllProducts,
                SelectedCategoryName = categoryRepository.AllCategories.ToList()[2].Name

            };
            return View(productListVM);

        }
        public IActionResult Details(int id)
        {
            var product = productRepository.GetProductById(id);
            return View(product);

        }
    }
}
