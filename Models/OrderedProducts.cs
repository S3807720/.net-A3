using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsShopping.Models
{
    public class OrderedProducts
    {
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        [JsonIgnore]
        public virtual Order Order { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        [JsonIgnore]
        public virtual Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
