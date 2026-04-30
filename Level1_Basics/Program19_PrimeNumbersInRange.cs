using System;

namespace CSharpPrograms
{
    public class Program19_PrimeNumbersInRange
    {
        public static void Main()
        {
            // Program 19: Prime numbers in a range
            Console.Write("Start: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("End: ");
            int end = Convert.ToInt32(Console.ReadLine());
            for (int n = Math.Max(2, start); n <= end; n++)
            {
                bool prime = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) { prime = false; break; }
                }
                if (prime) Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}

