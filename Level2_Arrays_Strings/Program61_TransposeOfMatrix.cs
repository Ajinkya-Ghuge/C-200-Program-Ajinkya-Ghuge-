using System;

namespace Level2_Arrays_Strings
{
    public class Program61_TransposeOfMatrix
    {
        public static void Main()
        {
            // Program 61: Transpose of matrix.
            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"M[{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Transpose:");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++) Console.Write(matrix[j, i] + " ");
                Console.WriteLine();
            }
        }

    }
}
