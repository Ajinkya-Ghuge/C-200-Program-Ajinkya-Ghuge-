using System;

namespace CSharpPrograms
{
    public class Program04_MaximumOfTwoNumbers
    {
        public static void Main()
        {
            // Program 4: Maximum of two numbers
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Maximum = {Math.Max(a, b)}");
        }
    }
}

