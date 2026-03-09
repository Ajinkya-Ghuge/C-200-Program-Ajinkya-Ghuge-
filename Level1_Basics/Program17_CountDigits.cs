using System;

namespace CSharpPrograms
{
    public class Program17_CountDigits
    {
        public static void Main()
        {
            // Program 17: Count digits in a number
            Console.Write("Enter a number: ");
            int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int count = (n == 0) ? 1 : 0;
            while (n > 0)
            {
                count++;
                n /= 10;
            }
            Console.WriteLine($"Digit count = {count}");
        }
    }
}

