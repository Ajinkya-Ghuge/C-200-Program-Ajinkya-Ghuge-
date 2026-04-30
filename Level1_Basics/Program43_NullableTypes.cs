using System;

namespace CSharpPrograms
{
    public class Program43_NullableTypes
    {
        public static void Main()
        {
            // Program 43: Nullable types demonstration
            int? number = null; // Nullable int can store null
            Console.WriteLine(number.HasValue ? $"Value = {number.Value}" : "Value is null");
            number = 10;
            Console.WriteLine($"After assignment = {number}");
        }
    }
}

