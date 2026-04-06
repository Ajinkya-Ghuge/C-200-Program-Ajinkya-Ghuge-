using System;
using System.Collections.Generic;

namespace Level2_Arrays_Strings
{
    public class Program96_DuplicateElementsInArray
    {
        public static void Main()
        {
            // Program 96: Find duplicate elements in array.
            int[] arr = { 1, 2, 3, 2, 4, 5, 1, 6, 3 };
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int item in arr)
            {
                if (!seen.Add(item)) duplicates.Add(item);
            }

            Console.WriteLine("Duplicate elements:");
            foreach (int item in duplicates) Console.Write(item + " ");
            Console.WriteLine();
        }

    }
}
