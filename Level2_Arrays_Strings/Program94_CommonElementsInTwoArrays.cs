using System;
using System.Collections.Generic;

namespace Level2_Arrays_Strings
{
    public class Program94_CommonElementsInTwoArrays
    {
        public static void Main()
        {
            // Program 94: Find common elements in two arrays.
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 4, 5, 6, 7, 8 };

            HashSet<int> set = new HashSet<int>(a);
            Console.WriteLine("Common elements:");
            foreach (int item in b)
            {
                if (set.Contains(item)) Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
