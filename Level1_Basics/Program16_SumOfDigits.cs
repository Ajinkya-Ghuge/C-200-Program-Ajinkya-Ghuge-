using System;

namespace CSharpPrograms
{
    public class Program16_SumOfDigits
    {
        public static void Main()
        {
            // Program 16: Sum of digits
            Console.Write("Enter a number: ");
            int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine($"Sum of digits = {sum}");
        }
    }
}

