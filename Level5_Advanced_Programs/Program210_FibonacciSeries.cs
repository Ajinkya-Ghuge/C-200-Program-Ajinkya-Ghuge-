using System;

class Program210_FibonacciSeries
{
    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int a = 0, b = 1;
        Console.Write($"Fibonacci Series: {a} {b}");
        
        for (int i = 2; i < n; i++)
        {
            int next = a + b;
            Console.Write($" {next}");
            a = b;
            b = next;
        }
        Console.WriteLine();
    }
}