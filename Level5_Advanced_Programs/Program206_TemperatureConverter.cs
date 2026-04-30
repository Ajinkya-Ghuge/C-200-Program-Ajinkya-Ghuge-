using System;

class Program206_TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Choose option: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        
        if (choice == 1)
        {
            Console.Write("Enter temperature in Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = (c * 9/5) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {f:F2}");
        }
        else
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5/9;
            Console.WriteLine($"Temperature in Celsius: {c:F2}");
        }
    }
}