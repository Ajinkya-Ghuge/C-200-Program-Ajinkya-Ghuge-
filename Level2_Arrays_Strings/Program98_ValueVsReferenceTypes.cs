using System;

namespace Level2_Arrays_Strings
{
    public class Program98_ValueVsReferenceTypes
    {
        public static void Main()
        {
            // Program 98: Demonstrate value vs reference types.
            int a = 10;
            int b = a; // Value copy
            b = 20;
            Console.WriteLine($"Value types -> a: {a}, b: {b}");

            int[] x = { 1, 2, 3 };
            int[] y = x; // Reference copy
            y[0] = 99;
            Console.WriteLine($"Reference types -> x[0]: {x[0]}, y[0]: {y[0]}");
        }

    }
}
