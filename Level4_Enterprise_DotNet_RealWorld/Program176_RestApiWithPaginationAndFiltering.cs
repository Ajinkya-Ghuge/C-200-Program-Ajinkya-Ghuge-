using System;
using System.Collections.Generic;
using System.Linq;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program176_RestApiWithPaginationAndFiltering
    {
        public static void Run()
        {
            List<string> products = new List<string> { "Laptop", "Mouse", "Monitor", "Mobile", "Mic" };
            var page = products
                .Where(product => product.StartsWith("M", StringComparison.OrdinalIgnoreCase))
                .Skip(0)
                .Take(2);

            foreach (string product in page)
            {
                Console.WriteLine(product);
            }
        }
    }
}
