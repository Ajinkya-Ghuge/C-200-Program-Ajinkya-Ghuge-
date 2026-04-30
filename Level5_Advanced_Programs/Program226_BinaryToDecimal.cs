using System;

class Program226_BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine();
        
        int decimal_num = Convert.ToInt32(binary, 2);
        Console.WriteLine($"Decimal: {decimal_num}");
    }
}