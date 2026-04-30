using System;

namespace Level3_OOPs_Advanced
{
    public class Program122_TryCatchFinally
    {
        public static void Run()
        {
            try
            {
                int value = int.Parse("ABC");
                Console.WriteLine(value);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Catch block: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block always executes.");
            }
        }
    }
}
