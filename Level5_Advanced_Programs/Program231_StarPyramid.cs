using System;

class Program231_StarPyramid
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }
}