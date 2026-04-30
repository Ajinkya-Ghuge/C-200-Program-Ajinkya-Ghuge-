using System;

class Program234_FloydsTriangle
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int num = 1;
        
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{num++} ");
            }
            Console.WriteLine();
        }
    }
}