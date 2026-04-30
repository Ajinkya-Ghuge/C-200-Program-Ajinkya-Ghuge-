using System;
using System.Threading;

namespace Level3_OOPs_Advanced
{
    public class Program145_LockingAndSynchronization
    {
        public static void Run()
        {
            Counter counter = new Counter();

            Thread thread1 = new Thread(counter.Increment);
            Thread thread2 = new Thread(counter.Increment);

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            Console.WriteLine($"Final count: {counter.Value}");
        }

        private class Counter
        {
            private readonly object syncLock = new object();
            public int Value { get; private set; }

            public void Increment()
            {
                for (int i = 0; i < 1000; i++)
                {
                    lock (syncLock)
                    {
                        Value++;
                    }
                }
            }
        }
    }
}
