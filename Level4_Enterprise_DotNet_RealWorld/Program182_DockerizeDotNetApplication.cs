using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program182_DockerizeDotNetApplication
    {
        public static void Run()
        {
            Console.WriteLine("Sample Dockerfile");
            Console.WriteLine("FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build");
            Console.WriteLine("WORKDIR /src");
            Console.WriteLine("RUN dotnet publish -c Release -o /app");
        }
    }
}
