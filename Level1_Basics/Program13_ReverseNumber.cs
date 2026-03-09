using System;

namespace CSharpPrograms
{
    public class Program13_ReverseNumber
    {
        public static void Main()
        {
            // Program 13: Reverse a number
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = Math.Abs(n), rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            if (n < 0) rev = -rev;
            Console.WriteLine($"Reversed = {rev}");
        }
    }
}

