using LetsShopping.Models;
using System.Collections.Generic;

namespace LetsShopping.ViewModels
{
    public class OrderedProductsViewModel
    {
        public List<OrderedProducts> OrderedProducts { get; set; }
        public List<Product> Products { get; set; }
        public int? ProductID { get; set; }
    }
}
