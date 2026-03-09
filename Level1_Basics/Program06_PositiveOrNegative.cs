using System;

namespace CSharpPrograms
{
    public class Program06_PositiveOrNegative
    {
        public static void Main()
        {
            // Program 6: Positive or negative
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0) Console.WriteLine("Positive");
            else if (n < 0) Console.WriteLine("Negative");
            else Console.WriteLine("Zero");
        }
    }
}

