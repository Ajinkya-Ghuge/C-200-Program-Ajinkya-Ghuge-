using System;

class Program216_LongestWord
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        
        string[] words = input.Split(' ');
        string longest = "";
        
        foreach (string word in words)
        {
            if (word.Length > longest.Length)
                longest = word;
        }
        
        Console.WriteLine($"Longest word: '{longest}' ({longest.Length} chars)");
    }
}