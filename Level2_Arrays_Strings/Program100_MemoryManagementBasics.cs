using System;
using System.Collections.Generic;

namespace Level2_Arrays_Strings
{
    public class Program100_MemoryManagementBasics
    {
        public static void Main()
        {
            // Program 100: Demonstrate memory management basics.
            long before = GC.GetTotalMemory(false);
            Console.WriteLine($"Memory before allocation: {before} bytes");

            List<byte[]> blocks = new List<byte[]>();
            for (int i = 0; i < 20; i++)
            {
                // Allocate memory blocks.
                blocks.Add(new byte[1024 * 100]);
            }

            long afterAlloc = GC.GetTotalMemory(false);
            Console.WriteLine($"Memory after allocation: {afterAlloc} bytes");

            // Release references and force garbage collection.
            blocks = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            long afterGc = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory after GC: {afterGc} bytes");
        }

    }
}
