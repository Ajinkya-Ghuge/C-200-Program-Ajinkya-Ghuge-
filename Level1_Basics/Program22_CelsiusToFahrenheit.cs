using System;

namespace CSharpPrograms
{
    public class Program22_CelsiusToFahrenheit
    {
        public static void Main()
        {
            // Program 22: Celsius to Fahrenheit
            Console.Write("Enter Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine($"Fahrenheit = {f}");
        }
    }
}

