using System;
using System.Threading;

namespace Level3_OOPs_Advanced
{
    public class Program143_Multithreading
    {
        public static void Run()
        {
            Thread thread = new Thread(PrintNumbers);
            thread.Start();
            thread.Join();
        }

        private static void PrintNumbers()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Thread value: {i}");
            }
        }
    }
}
