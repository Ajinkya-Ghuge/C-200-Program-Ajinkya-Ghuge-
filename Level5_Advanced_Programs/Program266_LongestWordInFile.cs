using System;
using System.IO;

class Program266_LongestWordInFile
{
    static void Main()
    {
        if (File.Exists("output.txt"))
        {
            string content = File.ReadAllText("output.txt");
            string[] words = content.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            
            string longest = "";
            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                    longest = word;
            }
            
            Console.WriteLine($"Longest word: '{longest}' ({longest.Length} chars)");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}