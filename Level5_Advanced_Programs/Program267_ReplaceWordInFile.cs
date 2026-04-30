using System;
using System.IO;

class Program267_ReplaceWordInFile
{
    static void Main()
    {
        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();
        Console.Write("Enter replacement word: ");
        string newWord = Console.ReadLine();
        
        string content = File.ReadAllText("output.txt");
        content = content.Replace(oldWord, newWord);
        File.WriteAllText("output.txt", content);
        
        Console.WriteLine("Word replaced successfully!");
    }
}