﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public DateTime ShoppingDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
