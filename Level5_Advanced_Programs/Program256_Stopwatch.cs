using System;
using System.Diagnostics;
using System.Threading;

class Program256_Stopwatch
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        
        Console.WriteLine("Stopwatch started...");
        Thread.Sleep(2000); // Wait 2 seconds
        
        sw.Stop();
        Console.WriteLine($"Elapsed time: {sw.ElapsedMilliseconds} ms");
    }
}