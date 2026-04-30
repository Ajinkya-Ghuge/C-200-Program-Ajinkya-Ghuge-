using System;
using System.Collections.Generic;
using System.Linq;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program196_HighPerformanceApiDesign
    {
        public static void Run()
        {
            List<int> values = Enumerable.Range(1, 1000).ToList();
            int total = values.Where(value => value % 2 == 0).Take(100).Sum();

            Console.WriteLine("High-performance API ideas: paging, caching, async I/O, minimal allocations.");
            Console.WriteLine($"Sample optimized query result: {total}");
        }
    }
}
