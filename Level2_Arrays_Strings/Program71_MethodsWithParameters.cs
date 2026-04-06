using System;

namespace Level2_Arrays_Strings
{
    public class Program71_MethodsWithParameters
    {
        public static void Main()
        {
            // Program 71: Methods with parameters.
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Add(a, b);

            static void Add(int x, int y)
            {
                Console.WriteLine($"Sum = {x + y}");
            }
        }

    }
}
