using System;
using System.IO;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program177_RestApiWithFileUploadDownload
    {
        public static void Run()
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "upload-demo.txt");
            File.WriteAllText(filePath, "Uploaded file content");

            Console.WriteLine("File uploaded successfully.");
            Console.WriteLine($"Downloaded content: {File.ReadAllText(filePath)}");
        }
    }
}
