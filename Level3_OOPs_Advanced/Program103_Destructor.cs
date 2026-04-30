using System;

namespace Level3_OOPs_Advanced
{
    public class Program103_Destructor
    {
        public static void Run()
        {
            ResourceHolder holder = new ResourceHolder();
            holder.Show();

            holder = null!;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Destructor executed after garbage collection.");
        }

        private class ResourceHolder
        {
            public void Show()
            {
                Console.WriteLine("Object created.");
            }

            ~ResourceHolder()
            {
                Console.WriteLine("Destructor called: resources cleaned up.");
            }
        }
    }
}
