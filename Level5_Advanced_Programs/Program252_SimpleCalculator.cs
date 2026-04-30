using System;

class Program252_SimpleCalculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine($"Subtraction: {a - b}");
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine($"Division: {a / b}");
    }
}