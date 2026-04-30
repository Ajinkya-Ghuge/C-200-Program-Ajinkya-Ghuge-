using System;

class Program219_ReplaceWord
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();
        Console.Write("Enter replacement word: ");
        string newWord = Console.ReadLine();
        
        string result = sentence.Replace(oldWord, newWord);
        Console.WriteLine($"Result: {result}");
    }
}