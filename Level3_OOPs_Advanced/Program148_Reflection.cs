using System;
using System.Reflection;

namespace Level3_OOPs_Advanced
{
    public class Program148_Reflection
    {
        public static void Run()
        {
            Type type = typeof(Product);
            Console.WriteLine($"Type Name: {type.Name}");

            foreach (PropertyInfo property in type.GetProperties())
            {
                Console.WriteLine($"Property: {property.Name}");
            }
        }

        private class Product
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
        }
    }
}
