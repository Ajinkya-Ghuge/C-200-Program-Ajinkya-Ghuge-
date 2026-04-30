using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program174_RestApiWithCachingRedis
    {
        public static void Run()
        {
            Dictionary<string, string> cache = new Dictionary<string, string>();
            cache["product:1"] = "Laptop";

            Console.WriteLine("Redis-style cache lookup");
            Console.WriteLine(cache.TryGetValue("product:1", out string? value)
                ? $"Cache hit: {value}"
                : "Cache miss");
        }
    }
}
