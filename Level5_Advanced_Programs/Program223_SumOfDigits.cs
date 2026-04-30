using System;

class Program223_SumOfDigits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0, temp = Math.Abs(num);
        
        while (temp > 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        
        Console.WriteLine($"Sum of digits: {sum}");
    }
}