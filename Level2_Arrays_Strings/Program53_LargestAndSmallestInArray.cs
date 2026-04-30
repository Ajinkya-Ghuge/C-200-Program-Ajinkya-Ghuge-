using System;

namespace Level2_Arrays_Strings
{
    public class Program53_LargestAndSmallestInArray
    {
        public static void Main()
        {
            // Program 53: Find largest and smallest element in array.
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = arr[0];
            int smallest = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > largest) largest = arr[i];
                if (arr[i] < smallest) smallest = arr[i];
            }

            Console.WriteLine($"Largest = {largest}");
            Console.WriteLine($"Smallest = {smallest}");
        }

    }
}
