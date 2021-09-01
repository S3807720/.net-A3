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
                   Price = 4.35M
               },
               new Product
               {
                   Name = "Spork",
                   Price = 2.35M
               },
               new Product
               {
                   Name = "Jumping Castle",
                   Price = 74.35M
               },
               new Product
               {
                   Name = "Banana",
                   Price = 0.35M
               },
               new Product
               {
                   Name = "French Onion",
                   Price = 1.35M
               },
               new Product
               {
                   Name = "Gold Ingot",
                   Price = 752.35M
               },
               new Product
               {
                   Name = "Toy Castle",
                   Price = 12.55M
               }
                );

            context.Orders.AddRange(
              new Order
              {
                  OrderID = 1,
                  OrderDate = DateTime.Now,
                  CustomerName = "Jeffrey Winger",
                  DeliveryAddress = "123 Fake St",
                  DeliveredDate = DateTime.Now.AddDays(5),
              },
              new Order
              {
                  OrderID = 2,
                  OrderDate = DateTime.Now,
                  CustomerName = "Starshine Boatface",
                  DeliveryAddress = "732 Real St",
                  DeliveredDate = DateTime.Now.AddDays(15),
              }

              );
            context.OrderedProducts.AddRange(
                new OrderedProducts
                {
                    OrderID = 1,
                    ProductID = 1,
                    Quantity = 3
                },
                new OrderedProducts
                {
                    OrderID = 1,
                    ProductID = 2,
                    Quantity = 4
                },
                new OrderedProducts
                {
                    OrderID = 2,
                    ProductID = 3,
                    Quantity = 7
                },
                new OrderedProducts
                {
                    OrderID = 2,
                    ProductID = 5,
                    Quantity = 12
                },
                new OrderedProducts
                {
                    OrderID = 2,
                    ProductID = 1,
                    Quantity = 1
                }
                );
            context.SaveChanges();
        }
    }
}
