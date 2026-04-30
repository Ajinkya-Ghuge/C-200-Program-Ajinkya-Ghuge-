using System;

class Program238_PascalTriangle
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ', (n - i) * 2));
            int val = 1;
            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{val,4}");
                val = val * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }
}