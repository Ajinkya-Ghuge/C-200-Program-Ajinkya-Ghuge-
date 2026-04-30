using System;
using System.Collections.Generic;
using System.Linq;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program158_CrudUsingEfCore
    {
        public static void Run()
        {
            FakeDbContext context = new FakeDbContext();
            context.Products.Add(new Product { Id = 1, Name = "Laptop" });
            context.Products.Add(new Product { Id = 2, Name = "Monitor" });

            Product? product = context.Products.FirstOrDefault(item => item.Id == 1);
            if (product != null)
            {
                product.Name = "Gaming Laptop";
            }

            context.Products.RemoveAll(item => item.Id == 2);

            foreach (Product item in context.Products)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }
        }

        private class FakeDbContext
        {
            public List<Product> Products { get; } = new List<Product>();
        }

        private class Product
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
        }
    }
}
