using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program155_InventoryManagementSystem
    {
        public static void Run()
        {
            List<Product> products = new List<Product>
            {
                new Product("Laptop", 5),
                new Product("Mouse", 25)
            };

            Console.WriteLine("Inventory Management System");
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name} - Stock: {product.Quantity}");
            }
        }

        private record Product(string Name, int Quantity);
    }
}
