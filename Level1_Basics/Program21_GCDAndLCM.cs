using System;

namespace CSharpPrograms
{
    public class Program21_GCDAndLCM
    {
        public static void Main()
        {
            // Program 21: GCD and LCM
            Console.Write("Enter first number: ");
            int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter second number: ");
            int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int x = a, y = b;
            while (y != 0)
            {
                int t = y;
                y = x % y;
                x = t;
            }
            int gcd = x;
            int lcm = (a == 0 || b == 0) ? 0 : (a / gcd) * b;
            Console.WriteLine($"GCD = {gcd}");
            Console.WriteLine($"LCM = {lcm}");
        }
    }
}

