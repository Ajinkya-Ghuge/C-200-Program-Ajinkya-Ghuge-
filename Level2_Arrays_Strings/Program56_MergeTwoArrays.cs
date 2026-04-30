using System;

namespace Level2_Arrays_Strings
{
    public class Program56_MergeTwoArrays
    {
        public static void Main()
        {
            // Program 56: Merge two arrays.
            Console.Write("Enter size of first array: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                Console.Write($"A[{i}]: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter size of second array: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.Write($"B[{i}]: ");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] merged = new int[n1 + n2];
            for (int i = 0; i < n1; i++) merged[i] = a[i];
            for (int i = 0; i < n2; i++) merged[n1 + i] = b[i];

            Console.WriteLine("Merged array:");
            foreach (int item in merged) Console.Write(item + " ");
            Console.WriteLine();
        }

    }
}
