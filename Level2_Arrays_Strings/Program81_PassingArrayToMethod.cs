using System;

namespace Level2_Arrays_Strings
{
    public class Program81_PassingArrayToMethod
    {
        public static void Main()
        {
            // Program 81: Demonstrate passing array to method.
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            PrintArray(arr);

            static void PrintArray(int[] values)
            {
                Console.WriteLine("Array values:");
                foreach (int item in values) Console.Write(item + " ");
                Console.WriteLine();
            }
        }

    }
}
