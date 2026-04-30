using System;
using System.IO;

class Program269_LogSystem
{
    static void Main()
    {
        string logFile = "app.log";
        string message = $"[{DateTime.Now}] Application event logged";
        
        File.AppendAllText(logFile, message + Environment.NewLine);
        Console.WriteLine("Log entry added!");
    }
}