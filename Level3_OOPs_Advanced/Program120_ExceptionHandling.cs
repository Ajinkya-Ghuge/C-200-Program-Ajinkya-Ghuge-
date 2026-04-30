using System;

namespace Level3_OOPs_Advanced
{
    public class Program120_ExceptionHandling
    {
        public static void Run()
        {
            try
            {
                int number = 10;
                int result = number / int.Parse("0");
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Handled exception: {ex.Message}");
            }
        }
    }
}
