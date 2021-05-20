using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartDemo.Models
{
    public class EFCatergoryRepository :ICategoryRepository
    {
        private readonly AppDBContext appDBContext;

        public EFCatergoryRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Category> AllCategories => appDBContext.Categories;
    }
}
