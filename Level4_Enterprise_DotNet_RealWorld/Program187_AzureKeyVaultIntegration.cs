using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program187_AzureKeyVaultIntegration
    {
        public static void Run()
        {
            Console.WriteLine("Secret retrieved from Key Vault: DbPassword");
            Console.WriteLine("Value is never logged in plain text.");
        }
    }
}
