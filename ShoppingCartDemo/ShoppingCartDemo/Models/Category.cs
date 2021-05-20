﻿using System.Collections.Generic;

namespace ShoppingCartDemo.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set;}
        public List<Product> Products { get; set; }

    }
}