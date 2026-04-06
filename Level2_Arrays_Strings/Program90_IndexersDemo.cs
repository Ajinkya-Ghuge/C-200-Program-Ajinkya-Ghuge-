using System;

namespace Level2_Arrays_Strings
{
    public class Program90_IndexersDemo
    {
        public static void Main()
        {
            // Program 90: Demonstrate indexers.
            NumberStore store = new NumberStore(5);
            for (int i = 0; i < 5; i++)
            {
                store[i] = (i + 1) * 10;
            }

            Console.WriteLine("Values from indexer:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"store[{i}] = {store[i]}");
            }
        }

    // Helper class with indexer.
    public class NumberStore
    {
        private int[] data;

        public NumberStore(int size)
        {
            data = new int[size];
        }

        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }
    }
}
