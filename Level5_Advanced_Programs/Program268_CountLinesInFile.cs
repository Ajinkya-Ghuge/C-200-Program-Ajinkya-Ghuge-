using System;
using System.IO;

class Program268_CountLinesInFile
{
    static void Main()
    {
        if (File.Exists("output.txt"))
        {
            string[] lines = File.ReadAllLines("output.txt");
            Console.WriteLine($"Line count: {lines.Length}");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}