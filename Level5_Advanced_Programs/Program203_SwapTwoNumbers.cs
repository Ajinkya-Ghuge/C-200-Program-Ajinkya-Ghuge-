using System;

class Program203_SwapTwoNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Before swap: a={a}, b={b}");
        
        // Swap with temp
        int temp = a;
        a = b;
        b = temp;
        
        Console.WriteLine($"After swap: a={a}, b={b}");
    }
}