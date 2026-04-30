using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program192_MultiTenantApplicationBasic
    {
        public static void Run()
        {
            Dictionary<string, string> tenantDatabases = new Dictionary<string, string>
            {
                ["TenantA"] = "ServerA_AppDb",
                ["TenantB"] = "ServerB_AppDb"
            };

            string currentTenant = "TenantA";
            Console.WriteLine($"Tenant: {currentTenant}");
            Console.WriteLine($"Database: {tenantDatabases[currentTenant]}");
        }
    }
}
