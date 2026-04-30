using System;

namespace CSharpPrograms
{
    public class Program03_AddTwoNumbers
    {
        public static void Main()
        {
            // Program 3: Add two numbers
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Sum = {a + b}");
        }
    }
}

