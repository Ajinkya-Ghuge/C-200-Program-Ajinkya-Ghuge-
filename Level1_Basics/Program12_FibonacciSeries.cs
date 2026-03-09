using System;

namespace CSharpPrograms
{
    public class Program12_FibonacciSeries
    {
        public static void Main()
        {
            // Program 12: Fibonacci series
            Console.Write("Enter number of terms: ");
            int terms = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1;
            for (int i = 0; i < terms; i++)
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine();
        }
    }
}

