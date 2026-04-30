using System;

namespace Level3_OOPs_Advanced
{
    public class Program133_LambdaExpressions
    {
        public static void Run()
        {
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"Sum: {add(10, 20)}");
        }
    }
}
