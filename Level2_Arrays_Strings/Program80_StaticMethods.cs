using System;

namespace Level2_Arrays_Strings
{
    public class Program80_StaticMethods
    {
        public static void Main()
        {
            // Program 80: Demonstrate static methods.
            Console.Write("Enter radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of circle = {CalculateArea(r)}");

            static double CalculateArea(double radius)
            {
                return Math.PI * radius * radius;
            }
        }

    }
}
