using System;

class Program240_AlphabetTriangle
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            char ch = 'A';
            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{ch} ");
                ch++;
            }
            Console.WriteLine();
        }
    }
}