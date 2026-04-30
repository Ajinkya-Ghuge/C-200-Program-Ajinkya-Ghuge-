using System;
using System.Collections.Generic;

class Program246_RemoveDuplicatesArray
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 1, 5, 3 };
        HashSet<int> unique = new HashSet<int>(arr);
        
        Console.WriteLine("Array without duplicates: " + string.Join(", ", unique));
    }
}