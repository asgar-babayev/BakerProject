using BakerProject.Models;
using System.Collections.Generic;

namespace BakerProject.ViewModels
{
    public class ShopVm
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
