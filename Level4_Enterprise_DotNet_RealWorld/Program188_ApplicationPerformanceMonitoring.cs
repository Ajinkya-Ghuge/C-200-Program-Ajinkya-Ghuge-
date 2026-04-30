using System;
using System.Diagnostics;
using System.Threading;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program188_ApplicationPerformanceMonitoring
    {
        public static void Run()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine($"Response time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
