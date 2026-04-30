using System;

class Program221_ArmstrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int original = num, sum = 0;
        
        while (num > 0)
        {
            int digit = num % 10;
            sum += digit * digit * digit;
            num /= 10;
        }
        
        if (sum == original)
            Console.WriteLine($"{original} is an Armstrong Number");
        else
            Console.WriteLine($"{original} is NOT an Armstrong Number");
    }
}