using System;

class Program248_CountEvenOdd
{
    static void Main()
    {
        int[] arr = { 12, 45, 23, 67, 89, 34, 56, 78 };
        int even = 0, odd = 0;
        
        foreach (int num in arr)
        {
            if (num % 2 == 0) even++;
            else odd++;
        }
        
        Console.WriteLine($"Even: {even}, Odd: {odd}");
    }
}