using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsShopping.Models
{
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }
        [Required, MaxLength(40)]
        public string Name { get; set; }
        [Required, MaxLength(80)]
        public string Address { get; set; }
        [Required, DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Balance { get; init; }
        public DateTime RegistrationDate { get; set; }
    }
}
