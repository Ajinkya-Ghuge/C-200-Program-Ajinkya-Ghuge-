using System;
using System.Threading;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program178_BackgroundWorkerUsingHostedServices
    {
        public static void Run()
        {
            Console.WriteLine("Background worker started.");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Executing background job {i}");
                Thread.Sleep(100);
            }
            Console.WriteLine("Background worker stopped.");
        }
    }
}
