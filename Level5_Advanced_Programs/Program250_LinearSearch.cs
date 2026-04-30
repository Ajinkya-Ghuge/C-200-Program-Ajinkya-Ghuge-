using System;

class Program250_LinearSearch
{
    static void Main()
    {
        int[] arr = { 12, 45, 23, 67, 89, 34 };
        Console.Write("Enter number to search: ");
        int target = Convert.ToInt32(Console.ReadLine());
        
        int index = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                index = i;
                break;
            }
        }
        
        if (index != -1)
            Console.WriteLine($"Found at index {index}");
        else
            Console.WriteLine("Not found");
    }
}