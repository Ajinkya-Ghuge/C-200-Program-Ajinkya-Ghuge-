using System;

class Program247_MergeArrays
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 4, 5, 6 };
        int[] merged = new int[arr1.Length + arr2.Length];
        
        Array.Copy(arr1, merged, arr1.Length);
        Array.Copy(arr2, 0, merged, arr1.Length, arr2.Length);
        
        Console.WriteLine("Merged array: " + string.Join(", ", merged));
    }
}