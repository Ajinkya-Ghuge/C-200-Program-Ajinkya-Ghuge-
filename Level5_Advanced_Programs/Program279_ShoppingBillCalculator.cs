using System;

class Program279_ShoppingBillCalculator
{
    static void Main()
    {
        Console.Write("Enter number of items: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double total = 0;
        
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Item {i} price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            total += price * qty;
        }
        
        Console.WriteLine($"Total Bill: ${total:F2}");
    }
}