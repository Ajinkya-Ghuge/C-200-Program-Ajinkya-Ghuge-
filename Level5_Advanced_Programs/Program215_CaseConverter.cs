using System;

class Program215_CaseConverter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        Console.WriteLine($"Uppercase: {input.ToUpper()}");
        Console.WriteLine($"Lowercase: {input.ToLower()}");
    }
}