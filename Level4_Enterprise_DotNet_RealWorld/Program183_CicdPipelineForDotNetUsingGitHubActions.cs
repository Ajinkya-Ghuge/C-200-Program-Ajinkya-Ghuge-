using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program183_CicdPipelineForDotNetUsingGitHubActions
    {
        public static void Run()
        {
            Console.WriteLine("GitHub Actions Steps");
            Console.WriteLine("- checkout");
            Console.WriteLine("- setup-dotnet");
            Console.WriteLine("- dotnet restore");
            Console.WriteLine("- dotnet build");
            Console.WriteLine("- dotnet test");
        }
    }
}
