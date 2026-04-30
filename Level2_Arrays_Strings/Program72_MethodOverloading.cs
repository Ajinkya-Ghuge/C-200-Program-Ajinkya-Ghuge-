using System;

namespace Level2_Arrays_Strings
{
    public class Program72_MethodOverloading
    {
        public static void Main()
        {
            // Program 72: Method overloading.
            Console.WriteLine($"Add(int, int) = {Add(5, 10)}");
            Console.WriteLine($"Add(double, double) = {Add(5.5, 10.2)}");
        }

        // Overloaded method for integer addition.
        private static int Add(int a, int b) => a + b;

        // Overloaded method for double addition.
        private static double Add(double a, double b) => a + b;
    }
}
