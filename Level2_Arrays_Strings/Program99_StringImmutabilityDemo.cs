using System;

namespace Level2_Arrays_Strings
{
    public class Program99_StringImmutabilityDemo
    {
        public static void Main()
        {
            // Program 99: Demonstrate immutability of strings.
            string s1 = "Hello";
            string s2 = s1;
            s1 = s1 + " World";

            Console.WriteLine("s1 = " + s1);
            Console.WriteLine("s2 = " + s2);
            Console.WriteLine("Original string was not modified, a new string was created.");
        }

    }
}
