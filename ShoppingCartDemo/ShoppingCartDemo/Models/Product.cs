using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartDemo.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
       public bool IsWeekendProductAvailable { get; set; }
        public Category category { get; set; }

        public bool isFreeThisWeek { get; set; }
    }
}
