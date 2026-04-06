using System;

namespace Level2_Arrays_Strings
{
    public class Program59_MatrixAddition
    {
        public static void Main()
        {
            // Program 59: Matrix addition.
            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[rows, cols];
            int[,] b = new int[rows, cols];
            int[,] sum = new int[rows, cols];

            Console.WriteLine("Enter first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"A[{i},{j}]: ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"B[{i},{j}]: ");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                    sum[i, j] = a[i, j] + b[i, j];
                }
            }

            Console.WriteLine("Sum matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++) Console.Write(sum[i, j] + " ");
                Console.WriteLine();
            }
        }

    }
}
