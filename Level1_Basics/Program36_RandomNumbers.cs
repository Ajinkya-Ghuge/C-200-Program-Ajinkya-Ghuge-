using System;

namespace CSharpPrograms
{
    public class Program36_RandomNumbers
    {
        public static void Main()
        {
            // Program 36: Random numbers
            Random random = new Random();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(random.Next(1, 101));
            }
        }
    }
}

