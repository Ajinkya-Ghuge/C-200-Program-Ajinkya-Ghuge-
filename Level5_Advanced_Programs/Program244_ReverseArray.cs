using System;

class Program244_ReverseArray
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Array.Reverse(arr);
        
        Console.WriteLine("Reversed array: " + string.Join(", ", arr));
    }
}