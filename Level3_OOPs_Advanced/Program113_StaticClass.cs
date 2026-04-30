using System;

namespace Level3_OOPs_Advanced
{
    public class Program113_StaticClass
    {
        public static void Run()
        {
            Console.WriteLine($"Square of 6: {MathUtility.Square(6)}");
            Console.WriteLine($"Cube of 4: {MathUtility.Cube(4)}");
        }

        private static class MathUtility
        {
            public static int Square(int number) => number * number;
            public static int Cube(int number) => number * number * number;
        }
    }
}
