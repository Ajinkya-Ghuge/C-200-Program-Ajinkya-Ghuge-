using System;
using System.Threading.Tasks;

namespace Level3_OOPs_Advanced
{
    public class Program142_AsyncAwait
    {
        public static async Task Run()
        {
            Console.WriteLine("Starting async operation...");
            string result = await FetchDataAsync();
            Console.WriteLine(result);
        }

        private static async Task<string> FetchDataAsync()
        {
            await Task.Delay(500);
            return "Async operation completed.";
        }
    }
}
