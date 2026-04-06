using System;

namespace Level2_Arrays_Strings
{
    public class Program54_SortArrayElements
    {
        public static void Main()
        {
            // Program 54: Sort array elements.
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);
            Console.WriteLine("Sorted array:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
