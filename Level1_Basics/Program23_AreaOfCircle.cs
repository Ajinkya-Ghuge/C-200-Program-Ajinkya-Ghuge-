using System;

namespace CSharpPrograms
{
    public class Program23_AreaOfCircle
    {
        public static void Main()
        {
            // Program 23: Area of circle
            Console.Write("Enter radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine($"Area = {area}");
        }
    }
}

