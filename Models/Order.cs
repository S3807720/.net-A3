using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsShopping.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        [Required, MaxLength(50)]
        [RegularExpression("^[A-Z]+[a-zA-Z ]*$", ErrorMessage = "Name must start with a capital and consist of only letters and spaces.")]
        public string CustomerName { get; set; }
        [Required, MaxLength(200)]
        public string DeliveryAddress { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public virtual List<OrderedProducts> Products { get; set; }
    }
}
