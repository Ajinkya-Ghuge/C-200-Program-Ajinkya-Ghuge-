using System;

namespace Level2_Arrays_Strings
{
    public class Program75_FactorialUsingRecursion
    {
        public static void Main()
        {
            // Program 75: Factorial using recursion.
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial = {Factorial(n)}");

            static long Factorial(int x)
            {
                if (x <= 1) return 1;
                return x * Factorial(x - 1);
            }
        }

    }
}
