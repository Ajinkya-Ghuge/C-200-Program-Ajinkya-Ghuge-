using System;

class Program225_CountDigits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0, temp = Math.Abs(num);
        
        if (temp == 0) count = 1;
        
        while (temp > 0)
        {
            count++;
            temp /= 10;
        }
        
        Console.WriteLine($"Number of digits: {count}");
    }
}