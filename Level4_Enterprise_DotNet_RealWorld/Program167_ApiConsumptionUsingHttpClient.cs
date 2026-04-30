using System;
using System.Net.Http;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program167_ApiConsumptionUsingHttpClient
    {
        public static void Run()
        {
            using HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.example.com/products");

            Console.WriteLine($"Prepared request: {request.Method} {request.RequestUri}");
            Console.WriteLine("In a real app, client.SendAsync(request) would call the API.");
        }
    }
}
