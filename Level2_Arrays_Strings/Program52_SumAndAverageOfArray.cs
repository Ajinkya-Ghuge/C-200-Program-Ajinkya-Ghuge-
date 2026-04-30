using System;

namespace Level2_Arrays_Strings
{
    public class Program52_SumAndAverageOfArray
    {
        public static void Main()
        {
            // Program 52: Find sum and average of array.
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            double average = n > 0 ? (double)sum / n : 0;
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }

    }
}
