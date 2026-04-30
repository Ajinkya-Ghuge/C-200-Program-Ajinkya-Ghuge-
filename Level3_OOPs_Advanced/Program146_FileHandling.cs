using System;
using System.IO;

namespace Level3_OOPs_Advanced
{
    public class Program146_FileHandling
    {
        public static void Run()
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "sample.txt");
            File.WriteAllText(filePath, "File handling demo in C#.");

            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }
    }
}
