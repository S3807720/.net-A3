using Microsoft.EntityFrameworkCore;
using LetsShopping.Models;

namespace LetsShopping.Data
{
    public class LetsShoppingContext : DbContext
    {
        public LetsShoppingContext(DbContextOptions<LetsShoppingContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderedProducts> OrderedProducts { get; set; }
        public DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<OrderedProducts>().HasCheckConstraint("CH_OrderedProducts_Quantity", "Quantity > 0");
        }

    }
}
