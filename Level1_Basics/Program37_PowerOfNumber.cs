using System;

namespace CSharpPrograms
{
    public class Program37_PowerOfNumber
    {
        public static void Main()
        {
            // Program 37: Power of a number
            Console.Write("Enter base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter exponent: ");
            double exp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Result = {Math.Pow(baseNum, exp)}");
        }
    }
}

