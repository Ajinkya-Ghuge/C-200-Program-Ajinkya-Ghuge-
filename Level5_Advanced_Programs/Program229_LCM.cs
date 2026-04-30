using System;

class Program229_LCM
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        int gcd = a, tempA = a, tempB = b;
        while (tempB != 0)
        {
            int temp = tempB;
            tempB = tempA % tempB;
            tempA = temp;
        }
        gcd = tempA;
        
        int lcm = (a * b) / gcd;
        Console.WriteLine($"LCM: {lcm}");
    }
}