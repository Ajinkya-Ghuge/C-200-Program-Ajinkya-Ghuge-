using System;

class Program237_RightAngleTriangle
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }
}