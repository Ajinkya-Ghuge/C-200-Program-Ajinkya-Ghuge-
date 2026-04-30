using System;
using System.Collections.Generic;

class Program220_RemoveDuplicateChars
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        HashSet<char> seen = new HashSet<char>();
        string result = "";
        
        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                result += c;
            }
        }
        
        Console.WriteLine($"Without duplicates: {result}");
    }
}