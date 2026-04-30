using System;

class Program280_DiscountCalculator
{
    static void Main()
    {
        Console.Write("Enter original price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter discount percentage: ");
        double discount = Convert.ToDouble(Console.ReadLine());
        
        double discountAmount = price * discount / 100;
        double finalPrice = price - discountAmount;
        
        Console.WriteLine($"Discount: ${discountAmount:F2}");
        Console.WriteLine($"Final Price: ${finalPrice:F2}");
    }
}