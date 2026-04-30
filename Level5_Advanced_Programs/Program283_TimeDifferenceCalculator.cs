using System;

class Program283_TimeDifferenceCalculator
{
    static void Main()
    {
        Console.Write("Enter start time (HH:mm): ");
        DateTime start = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter end time (HH:mm): ");
        DateTime end = DateTime.Parse(Console.ReadLine());
        
        TimeSpan diff = end - start;
        Console.WriteLine($"Time difference: {diff.Hours} hours {diff.Minutes} minutes");
    }
}