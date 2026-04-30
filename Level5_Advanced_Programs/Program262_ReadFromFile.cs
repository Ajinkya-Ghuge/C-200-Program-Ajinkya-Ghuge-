using System;
using System.IO;

class Program262_ReadFromFile
{
    static void Main()
    {
        if (File.Exists("output.txt"))
        {
            string content = File.ReadAllText("output.txt");
            Console.WriteLine("File content: " + content);
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}