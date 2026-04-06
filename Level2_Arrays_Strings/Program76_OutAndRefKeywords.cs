using System;

namespace Level2_Arrays_Strings
{
    public class Program76_OutAndRefKeywords
    {
        public static void Main()
        {
            // Program 76: Demonstrate out and ref keywords.
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            DoubleValue(ref number);
            Console.WriteLine($"After ref method: {number}");

            GetSquareAndCube(number, out int square, out int cube);
            Console.WriteLine($"Square = {square}, Cube = {cube}");

            static void DoubleValue(ref int x)
            {
                x = x * 2;
            }

            static void GetSquareAndCube(int x, out int square, out int cube)
            {
                square = x * x;
                cube = x * x * x;
            }
        }

    }
}
