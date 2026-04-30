using System;

class Program241_FindMaxInArray
{
    static void Main()
    {
        int[] arr = { 12, 45, 23, 67, 89, 34 };
        int max = arr[0];
        
        foreach (int num in arr)
        {
            if (num > max) max = num;
        }
        
        Console.WriteLine($"Maximum element: {max}");
    }
}