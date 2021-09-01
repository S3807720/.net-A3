using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsShopping.Models
{
    public class OrderedProducts
    {
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public virtual List<Orders> Order { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual List<Product> Product { get; set; }
        public int Quantity { get; set; }
    }
}
