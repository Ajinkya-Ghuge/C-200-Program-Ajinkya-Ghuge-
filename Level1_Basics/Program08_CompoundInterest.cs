using System;

namespace CSharpPrograms
{
    public class Program08_CompoundInterest
    {
        public static void Main()
        {
            // Program 8: Compound interest
            Console.Write("Principal: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Rate (%): ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Time (years): ");
            double t = Convert.ToDouble(Console.ReadLine());
            double amount = p * Math.Pow(1 + r / 100, t);
            Console.WriteLine($"Compound Interest = {amount - p}");
        }
    }
}

