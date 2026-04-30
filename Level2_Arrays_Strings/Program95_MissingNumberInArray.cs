using System;

namespace Level2_Arrays_Strings
{
    public class Program95_MissingNumberInArray
    {
        public static void Main()
        {
            // Program 95: Find missing number in array (1 to n).
            Console.Write("Enter n (max number): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of elements (n-1): ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int actualSum = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                actualSum += arr[i];
            }

            int expectedSum = n * (n + 1) / 2;
            Console.WriteLine($"Missing number = {expectedSum - actualSum}");
        }

    }
}
