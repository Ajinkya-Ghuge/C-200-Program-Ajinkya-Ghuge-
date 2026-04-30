using System;

class Program227_DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        string binary = Convert.ToString(num, 2);
        Console.WriteLine($"Binary: {binary}");
    }
}