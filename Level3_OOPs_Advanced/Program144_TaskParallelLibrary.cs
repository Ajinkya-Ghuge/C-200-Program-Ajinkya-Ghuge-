using System;
using System.Threading.Tasks;

namespace Level3_OOPs_Advanced
{
    public class Program144_TaskParallelLibrary
    {
        public static void Run()
        {
            Parallel.For(1, 4, number =>
            {
                Console.WriteLine($"Parallel task processing: {number}");
            });
        }
    }
}
