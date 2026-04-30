using System;
using System.IO;

class Program270_FileSizeChecker
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();
        
        if (File.Exists(path))
        {
            FileInfo fi = new FileInfo(path);
            Console.WriteLine($"File size: {fi.Length} bytes");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}