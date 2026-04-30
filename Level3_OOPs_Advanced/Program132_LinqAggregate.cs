using System;
using System.Linq;

namespace Level3_OOPs_Advanced
{
    public class Program132_LinqAggregate
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int product = numbers.Aggregate((current, next) => current * next);
            Console.WriteLine($"Product: {product}");
        }
    }
}
