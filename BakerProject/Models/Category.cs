﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakerProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
