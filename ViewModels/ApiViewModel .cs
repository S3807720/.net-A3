using LetsShopping.Models;
using System.Collections.Generic;

namespace LetsShopping.ViewModels
{
    public class ApiViewModel
    {
        public List<OrderedProducts> OrderedProducts { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
    }
}
