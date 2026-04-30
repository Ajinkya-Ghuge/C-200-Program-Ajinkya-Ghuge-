using System;

class Program207_AreaOfShapes
{
    static void Main()
    {
        Console.WriteLine("1. Circle  2. Rectangle  3. Triangle  4. Square");
        Console.Write("Choose shape: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        
        double area = 0;
        
        switch(choice)
        {
            case 1:
                Console.Write("Enter radius: ");
                double r = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * r * r;
                Console.WriteLine($"Area of Circle: {area:F2}");
                break;
            case 2:
                Console.Write("Enter length: ");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter width: ");
                double w = Convert.ToDouble(Console.ReadLine());
                area = l * w;
                Console.WriteLine($"Area of Rectangle: {area:F2}");
                break;
            case 3:
                Console.Write("Enter base: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter height: ");
                double h = Convert.ToDouble(Console.ReadLine());
                area = 0.5 * b * h;
                Console.WriteLine($"Area of Triangle: {area:F2}");
                break;
            case 4:
                Console.Write("Enter side: ");
                double s = Convert.ToDouble(Console.ReadLine());
                area = s * s;
                Console.WriteLine($"Area of Square: {area:F2}");
                break;
        }
    }
}