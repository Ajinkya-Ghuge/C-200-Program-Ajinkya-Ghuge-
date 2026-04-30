using System;
using System.Collections.Generic;

namespace Level2_Arrays_Strings
{
    public class Program57_RemoveDuplicatesFromArray
    {
        public static void Main()
        {
            // Program 57: Remove duplicate elements from array.
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            HashSet<int> unique = new HashSet<int>();
            foreach (int item in arr) unique.Add(item);

            Console.WriteLine("Array after removing duplicates:");
            foreach (int item in unique) Console.Write(item + " ");
            Console.WriteLine();
        }

    }
}
