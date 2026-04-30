using System;

class Program242_FindMinInArray
{
    static void Main()
    {
        int[] arr = { 12, 45, 23, 67, 89, 34 };
        int min = arr[0];
        
        foreach (int num in arr)
        {
            if (num < min) min = num;
        }
        
        Console.WriteLine($"Minimum element: {min}");
    }
}