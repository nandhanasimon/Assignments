using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCartDemo.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly AppDBContext appDBContext;

        public EFProductRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Product> AllProducts
        {
            get
            {
                return appDBContext.Products.Include(c=>c.category);
            }
        }

        public IEnumerable<Product> FreeProductOfTheWeek => throw new NotImplementedException();

        public Product GetProductById(int productId)
        {
            return appDBContext.Products.Include(c=>c.category).FirstOrDefault(c => c.ProductId == productId);
        }
    }
}
