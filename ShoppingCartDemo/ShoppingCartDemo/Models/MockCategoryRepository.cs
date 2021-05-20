using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartDemo.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category> { 
        
            new Category {
            CategoryId=101,
            Name="Baking",
            Description="used for baking"
            },
            new Category{
            CategoryId=102,
            Name="International",
            Description="Items from different countries"
            },
            new Category{
            CategoryId=103,
            Name="Kids",
            Description="used for Kids and infants"
            }
        };

    }
}
