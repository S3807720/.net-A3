using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsShopping.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required, MaxLength(40)]
        [RegularExpression("^[A-Z]+[a-zA-Z0-9 ]*$", ErrorMessage = "Name must start with a capital and consist of only letters and spaces.")]
        public string Name { get; set; }
        [Required, DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}
