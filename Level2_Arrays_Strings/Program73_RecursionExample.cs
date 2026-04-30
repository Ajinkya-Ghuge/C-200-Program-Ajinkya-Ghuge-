using System;

namespace Level2_Arrays_Strings
{
    public class Program73_RecursionExample
    {
        public static void Main()
        {
            // Program 73: Recursion example (sum from 1 to n).
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum = {SumToN(n)}");

            static int SumToN(int x)
            {
                if (x <= 0) return 0;
                return x + SumToN(x - 1);
            }
        }

    }
}
