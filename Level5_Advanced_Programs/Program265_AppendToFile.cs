using System;
using System.IO;

class Program265_AppendToFile
{
    static void Main()
    {
        Console.Write("Enter text to append: ");
        string text = Console.ReadLine();
        
        File.AppendAllText("output.txt", Environment.NewLine + text);
        Console.WriteLine("Text appended successfully!");
    }
}