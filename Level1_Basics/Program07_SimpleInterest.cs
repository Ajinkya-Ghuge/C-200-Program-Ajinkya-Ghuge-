using System;

namespace CSharpPrograms
{
    public class Program07_SimpleInterest
    {
        public static void Main()
        {
            // Program 7: Simple interest
            Console.Write("Principal: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Rate: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Time (years): ");
            double t = Convert.ToDouble(Console.ReadLine());
            double si = (p * r * t) / 100;
            Console.WriteLine($"Simple Interest = {si}");
        }
    }
}

