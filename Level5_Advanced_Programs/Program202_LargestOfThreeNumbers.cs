using System;

class Program202_LargestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        
        int largest = a;
        if (b > largest) largest = b;
        if (c > largest) largest = c;
        
        Console.WriteLine($"Largest number: {largest}");
    }
}