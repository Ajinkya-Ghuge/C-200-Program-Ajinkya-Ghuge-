using System;
using System.Collections.Generic;

class Program217_CharFrequency
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();
        
        Dictionary<char, int> freq = new Dictionary<char, int>();
        
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }
        }
        
        foreach (var kvp in freq)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}