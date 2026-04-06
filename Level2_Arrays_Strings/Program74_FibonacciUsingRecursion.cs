using System;

namespace Level2_Arrays_Strings
{
    public class Program74_FibonacciUsingRecursion
    {
        public static void Main()
        {
            // Program 74: Fibonacci using recursion.
            Console.Write("Enter number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.WriteLine();

            static int Fibonacci(int x)
            {
                if (x <= 1) return x;
                return Fibonacci(x - 1) + Fibonacci(x - 2);
            }
        }

    }
}
