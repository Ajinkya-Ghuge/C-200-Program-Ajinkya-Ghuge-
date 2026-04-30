using System;
using System.Linq;

namespace Level3_OOPs_Advanced
{
    public class Program130_LinqGroupBy
    {
        public static void Run()
        {
            string[] words = { "apple", "ant", "banana", "ball", "cat" };

            var groupedWords = words.GroupBy(word => word[0]);

            foreach (var group in groupedWords)
            {
                Console.WriteLine($"Group {group.Key}: {string.Join(", ", group)}");
            }
        }
    }
}
