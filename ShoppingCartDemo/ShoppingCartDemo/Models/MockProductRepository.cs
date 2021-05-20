using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartDemo.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository categoryRepository;

        public MockProductRepository(ICategoryRepository repo)
        {
            categoryRepository = repo;
        }
        public IEnumerable<Product> AllProducts => new List<Product>
        {

            new Product{
            ProductId=10,
            ProductName="cake mix",
            Description=" use with the given baking directions",
            ImageUrl="https://tinyurl.com/2blb99zs",
            Price=13,
            IsWeekendProductAvailable=true,
            category=categoryRepository.AllCategories.ToList()[0]
            },
            new Product{
            ProductId=11,
            ProductName="cake cream",
            Description=" use with the given directions in different items",
            ImageUrl="https://tinyurl.com/2blb99zs",
            Price=20,
            IsWeekendProductAvailable=true,
            category=categoryRepository.AllCategories.ToList()[0]
            },
            new Product{
            ProductId=12,
            ProductName="Stroller",
            Description=" use with the given kids directions",
            ImageUrl="https://tinyurl.com/2blb99zs",
            Price=250,
            IsWeekendProductAvailable=false,
            category=categoryRepository.AllCategories.ToList()[2]
            },
            new Product{
            ProductId=13,
            ProductName="Dal",
            Description="directions provided backside",
            ImageUrl="https://tinyurl.com/2blb99zs",
            Price=10,
            IsWeekendProductAvailable=true,
            category=categoryRepository.AllCategories.ToList()[1]
            }
        };

        public IEnumerable<Product> FreeProductOfTheWeek {get;}

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(c => c.ProductId == productId);
        }
    }
}
