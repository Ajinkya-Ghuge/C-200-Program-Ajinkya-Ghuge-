using System;

namespace CSharpPrograms
{
    public class Program40_SumOfNaturalNumbers
    {
        public static void Main()
        {
            // Program 40: Sum of natural numbers
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = n * (n + 1) / 2; // Formula for first n natural numbers
            Console.WriteLine($"Sum = {sum}");
        }
    }
}

