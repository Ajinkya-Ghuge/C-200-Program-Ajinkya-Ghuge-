using System;

namespace CSharpPrograms
{
    public class Program49_MathClassDemo
    {
        public static void Main()
        {
            // Program 49: Math class demonstration
            double value = 25.64;
            Console.WriteLine($"Sqrt = {Math.Sqrt(value)}");
            Console.WriteLine($"Pow(value, 2) = {Math.Pow(value, 2)}");
            Console.WriteLine($"Round = {Math.Round(value)}");
            Console.WriteLine($"Floor = {Math.Floor(value)}");
            Console.WriteLine($"Ceiling = {Math.Ceiling(value)}");
            Console.WriteLine($"Abs(-10) = {Math.Abs(-10)}");
        }
    }
}

