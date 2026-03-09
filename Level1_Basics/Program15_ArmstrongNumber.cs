using System;

namespace CSharpPrograms
{
    public class Program15_ArmstrongNumber
    {
        public static void Main()
        {
            // Program 15: Check Armstrong number
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int original = n, digits = original.ToString().Length, sum = 0;
            while (n > 0)
            {
                int d = n % 10;
                sum += (int)Math.Pow(d, digits);
                n /= 10;
            }
            Console.WriteLine(original == sum ? "Armstrong Number" : "Not Armstrong Number");
        }
    }
}

