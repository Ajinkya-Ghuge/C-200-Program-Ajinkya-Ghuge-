using System;

class Program224_ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int reverse = 0, temp = Math.Abs(num);
        
        while (temp > 0)
        {
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        }
        
        if (num < 0) reverse = -reverse;
        Console.WriteLine($"Reversed number: {reverse}");
    }
}