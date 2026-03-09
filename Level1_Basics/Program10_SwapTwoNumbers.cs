using System;

namespace CSharpPrograms
{
    public class Program10_SwapTwoNumbers
    {
        public static void Main()
        {
            // Program 10: Swap two numbers
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swap: a = {a}, b = {b}");
        }
    }
}

