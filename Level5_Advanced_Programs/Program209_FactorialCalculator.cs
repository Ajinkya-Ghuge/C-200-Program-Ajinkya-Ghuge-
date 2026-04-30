using System;

class Program209_FactorialCalculator
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        long factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        
        Console.WriteLine($"Factorial of {n}: {factorial}");
    }
}