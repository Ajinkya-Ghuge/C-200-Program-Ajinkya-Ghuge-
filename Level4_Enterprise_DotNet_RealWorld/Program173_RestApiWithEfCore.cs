using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program173_RestApiWithEfCore
    {
        public static void Run()
        {
            List<Product> products = new List<Product>
            {
                new Product(1, "Laptop"),
                new Product(2, "Keyboard")
            };

            Console.WriteLine("GET /api/products");
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id} - {product.Name}");
            }
        }

        private record Product(int Id, string Name);
    }
}
