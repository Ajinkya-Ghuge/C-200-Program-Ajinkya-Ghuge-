using System;

namespace CSharpPrograms
{
    public class Program25_ASCIIValue
    {
        public static void Main()
        {
            // Program 25: ASCII value of a character
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"ASCII value of {ch} = {(int)ch}");
        }
    }
}

