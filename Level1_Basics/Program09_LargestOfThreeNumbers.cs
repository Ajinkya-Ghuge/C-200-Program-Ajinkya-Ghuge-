using System;

namespace CSharpPrograms
{
    public class Program09_LargestOfThreeNumbers
    {
        public static void Main()
        {
            // Program 9: Largest of three numbers
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Largest = {Math.Max(a, Math.Max(b, c))}");
        }
    }
}

