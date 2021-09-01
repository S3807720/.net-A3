using System;
using System.ComponentModel.DataAnnotations;

namespace LetsShopping.Models
{
    public class Orders
    {
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }
        [Required, MaxLength(50)]
        [RegularExpression("^[A-Z]+[a-zA-Z ]*$", ErrorMessage = "Name must start with a capital and consist of only letters and spaces.")]
        public string CustomerName { get; set; }
        [Required, MaxLength(200)]
        public string DeliveryAddress { get; set; }

        public DateTime? DeliveredDate { get; set; }
    }
}
