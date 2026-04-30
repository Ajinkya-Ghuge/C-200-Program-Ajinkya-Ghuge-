using System;

class Program218_CheckAnagram
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine().ToLower();
        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine().ToLower();
        
        char[] arr1 = s1.ToCharArray();
        char[] arr2 = s2.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);
        
        string sorted1 = new string(arr1);
        string sorted2 = new string(arr2);
        
        if (sorted1 == sorted2)
            Console.WriteLine("Strings are Anagrams");
        else
            Console.WriteLine("Strings are NOT Anagrams");
    }
}