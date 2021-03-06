﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        public DateTime ShoppingDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> ProductList { get; set; }
    }
}
