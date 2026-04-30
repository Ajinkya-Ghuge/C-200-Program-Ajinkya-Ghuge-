using System;

namespace Level2_Arrays_Strings
{
    public class Program55_ReverseArray
    {
        public static void Main()
        {
            // Program 55: Reverse an array.
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(arr);
            Console.WriteLine("Reversed array:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
