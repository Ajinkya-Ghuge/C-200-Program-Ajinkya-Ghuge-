using System;
using System.Collections.Generic;

namespace Level3_OOPs_Advanced
{
    public class Program128_HashSet
    {
        public static void Run()
        {
            HashSet<int> numbers = new HashSet<int> { 10, 20, 20, 30, 40 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
