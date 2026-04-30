using System;

class Program236_HollowSquare
{
    static void Main()
    {
        Console.Write("Enter side length: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == 1 || i == n || j == 1 || j == n)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }
    }
}