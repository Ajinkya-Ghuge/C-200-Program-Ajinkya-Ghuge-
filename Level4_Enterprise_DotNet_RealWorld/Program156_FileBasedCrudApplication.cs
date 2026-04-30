using System;
using System.IO;
using System.Text.Json;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program156_FileBasedCrudApplication
    {
        public static void Run()
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "products.json");
            Product product = new Product(1, "Keyboard", 1499m);

            string json = JsonSerializer.Serialize(product);
            File.WriteAllText(filePath, json);
            string savedJson = File.ReadAllText(filePath);

            Product? loadedProduct = JsonSerializer.Deserialize<Product>(savedJson);
            Console.WriteLine($"Loaded product: {loadedProduct?.Name} - {loadedProduct?.Price:C}");
        }

        private record Product(int Id, string Name, decimal Price);
    }
}
