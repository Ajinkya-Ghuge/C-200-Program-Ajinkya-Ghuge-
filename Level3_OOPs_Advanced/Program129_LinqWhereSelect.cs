using System;
using System.Linq;

namespace Level3_OOPs_Advanced
{
    public class Program129_LinqWhereSelect
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            var squaresOfEvenNumbers = numbers
                .Where(number => number % 2 == 0)
                .Select(number => number * number);

            foreach (int value in squaresOfEvenNumbers)
            {
                Console.WriteLine(value);
            }
        }
    }
}
