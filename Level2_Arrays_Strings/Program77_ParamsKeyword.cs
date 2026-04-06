using System;

namespace Level2_Arrays_Strings
{
    public class Program77_ParamsKeyword
    {
        public static void Main()
        {
            // Program 77: Demonstrate params keyword.
            Console.WriteLine("Sum(1,2,3) = " + Sum(1, 2, 3));
            Console.WriteLine("Sum(5,10,15,20) = " + Sum(5, 10, 15, 20));

            static int Sum(params int[] numbers)
            {
                int total = 0;
                foreach (int n in numbers) total += n;
                return total;
            }
        }

    }
}
