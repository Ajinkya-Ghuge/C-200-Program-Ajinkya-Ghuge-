using System;
using System.Collections;

namespace Level3_OOPs_Advanced
{
    public class Program124_CollectionsArrayList
    {
        public static void Run()
        {
            ArrayList items = new ArrayList { 10, "C#", true };

            foreach (object item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
