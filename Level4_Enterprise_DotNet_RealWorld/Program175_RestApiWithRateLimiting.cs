using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program175_RestApiWithRateLimiting
    {
        public static void Run()
        {
            int requests = 6;
            int limit = 5;

            Console.WriteLine(requests > limit
                ? "429 Too Many Requests"
                : "200 OK");
        }
    }
}
