using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program185_AzureSqlIntegrationWithDotNet
    {
        public static void Run()
        {
            string connectionString = "Server=tcp:demo.database.windows.net;Database=AppDb;Authentication=Active Directory Default;";
            Console.WriteLine("Azure SQL Integration Demo");
            Console.WriteLine(connectionString);
        }
    }
}
