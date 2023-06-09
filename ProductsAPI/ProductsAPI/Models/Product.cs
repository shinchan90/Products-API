﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public bool Availability { get; set; }
    }
}
