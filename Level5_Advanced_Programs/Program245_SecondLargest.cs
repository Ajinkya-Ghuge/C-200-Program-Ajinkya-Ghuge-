using System;

class Program245_SecondLargest
{
    static void Main()
    {
        int[] arr = { 12, 45, 23, 67, 89, 34 };
        int largest = int.MinValue, second = int.MinValue;
        
        foreach (int num in arr)
        {
            if (num > largest)
            {
                second = largest;
                largest = num;
            }
            else if (num > second && num != largest)
            {
                second = num;
            }
        }
        
        Console.WriteLine($"Second largest: {second}");
    }
}