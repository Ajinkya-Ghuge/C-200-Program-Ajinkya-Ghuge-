using System;

namespace Level3_OOPs_Advanced
{
    public class Program137_FuncActionPredicate
    {
        public static void Run()
        {
            Func<int, int, int> multiply = (a, b) => a * b;
            Action<string> display = message => Console.WriteLine(message);
            Predicate<int> isEven = number => number % 2 == 0;

            display($"Func result: {multiply(5, 4)}");
            display($"Predicate result for 10: {isEven(10)}");
        }
    }
}
