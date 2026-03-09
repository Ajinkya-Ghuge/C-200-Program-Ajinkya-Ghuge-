using System;

namespace CSharpPrograms
{
    public class Program24_AreaOfRectangle
    {
        public static void Main()
        {
            // Program 24: Area of rectangle
            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area = {length * width}");
        }
    }
}

