using System;

class Program208_PrimeNumberChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        bool isPrime = true;
        if (num <= 1) isPrime = false;
        
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        
        if (isPrime)
            Console.WriteLine($"{num} is a Prime number");
        else
            Console.WriteLine($"{num} is NOT a Prime number");
    }
}