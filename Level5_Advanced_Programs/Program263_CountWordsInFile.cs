using System;
using System.IO;

class Program263_CountWordsInFile
{
    static void Main()
    {
        if (File.Exists("output.txt"))
        {
            string content = File.ReadAllText("output.txt");
            string[] words = content.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Word count: {words.Length}");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}