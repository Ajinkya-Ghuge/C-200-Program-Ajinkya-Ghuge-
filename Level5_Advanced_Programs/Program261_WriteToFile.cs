using System;
using System.IO;

class Program261_WriteToFile
{
    static void Main()
    {
        Console.Write("Enter text to write: ");
        string text = Console.ReadLine();
        
        File.WriteAllText("output.txt", text);
        Console.WriteLine("Text written to file successfully!");
    }
}