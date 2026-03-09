using System;

namespace CSharpPrograms
{
    public class Program11_Factorial
    {
        public static void Main()
        {
            // Program 11: Factorial of a number
            Console.Write("Enter a non-negative integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long fact = 1;
            for (int i = 2; i <= n; i++) fact *= i;
            Console.WriteLine($"Factorial = {fact}");
        }
    }
}

