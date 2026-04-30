using System;
using System.IO;

class Program264_CopyFile
{
    static void Main()
    {
        if (File.Exists("output.txt"))
        {
            File.Copy("output.txt", "output_copy.txt", true);
            Console.WriteLine("File copied successfully!");
        }
        else
        {
            Console.WriteLine("Source file not found!");
        }
    }
}