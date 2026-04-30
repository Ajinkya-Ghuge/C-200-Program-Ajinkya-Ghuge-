using System;

class Program282_AgeCalculator
{
    static void Main()
    {
        Console.Write("Enter your birth year: ");
        int birthYear = Convert.ToInt32(Console.ReadLine());
        
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        
        Console.WriteLine($"Your age: {age} years");
    }
}