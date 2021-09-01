using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using LetsShopping.Models;

namespace LetsShopping.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<LetsShoppingContext>();

            // Look for customers.
            if(context.Products.Any())
                return; // DB has already been seeded.

            context.Products.AddRange(
               new Product
               {
                   Name = "Fork",
                   Description = "Use to eat", 
                   Price = 4.35M
               },
               new Product
               {
                   Name = "Spork",
                   Description = "Use to eat",
                   Price = 2.35M
               },
               new Product
               {
                   Name = "Jumping Castle",
                   Description = "Use to jump",
                   Price = 74.35M
               },
               new Product
               {
                   Name = "Banana",
                   Description = "Eating thing",
                   Price = 0.35M
               },
               new Product
               {
                   Name = "French Onion",
                   Description = "Use to eat",
                   Price = 1.35M
               },
               new Product
               {
                   Name = "Gold Ingot",
                   Description = "Use to keep",
                   Price = 752.35M
               },
               new Product
               {
                   Name = "Toy Castle",
                   Description = "Use to play",
                   Price = 12.55M
               }
                );
            context.SaveChanges();
        }
    }
}
