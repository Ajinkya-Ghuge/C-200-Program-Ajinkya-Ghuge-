using System;

namespace Level2_Arrays_Strings
{
    public class Program82_SecondLargestInArray
    {
        public static void Main()
        {
            // Program 82: Find second largest element in array.
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);
            Array.Reverse(arr);

            int secondLargest = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] != arr[0])
                {
                    secondLargest = arr[i];
                    break;
                }
            }

            Console.WriteLine($"Second largest = {secondLargest}");
        }

    }
}
