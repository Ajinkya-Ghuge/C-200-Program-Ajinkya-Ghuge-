using System;
using System.Diagnostics;
using System.Text;

namespace Level3_OOPs_Advanced
{
    public class Program150_PerformanceOptimizationBasics
    {
        public static void Run()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                builder.Append(i);
            }

            stopwatch.Stop();
            Console.WriteLine($"Built string of length {builder.Length} in {stopwatch.ElapsedTicks} ticks.");
        }
    }
}
