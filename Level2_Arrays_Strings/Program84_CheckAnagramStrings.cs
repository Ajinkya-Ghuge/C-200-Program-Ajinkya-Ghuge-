using System;

namespace Level2_Arrays_Strings
{
    public class Program84_CheckAnagramStrings
    {
        public static void Main()
        {
            // Program 84: Check anagram strings.
            Console.Write("Enter first string: ");
            string s1 = (Console.ReadLine() ?? "").ToLower().Replace(" ", "");
            Console.Write("Enter second string: ");
            string s2 = (Console.ReadLine() ?? "").ToLower().Replace(" ", "");

            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();
            Array.Sort(a1);
            Array.Sort(a2);

            bool isAnagram = new string(a1) == new string(a2);
            Console.WriteLine(isAnagram ? "Anagram strings" : "Not anagram strings");
        }

    }
}
