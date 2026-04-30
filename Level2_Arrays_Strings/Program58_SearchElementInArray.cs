using System;

namespace Level2_Arrays_Strings
{
    public class Program58_SearchElementInArray
    {
        public static void Main()
        {
            // Program 58: Search an element in array.
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter element to search: ");
            int key = Convert.ToInt32(Console.ReadLine());
            int index = Array.IndexOf(arr, key);

            if (index >= 0) Console.WriteLine($"Element found at index {index}");
            else Console.WriteLine("Element not found");
        }

    }
}
