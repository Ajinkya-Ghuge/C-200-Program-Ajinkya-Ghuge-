using System;
using System.IO;
using System.Text.Json;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program162_ConfigurationManagementUsingAppsettings
    {
        public static void Run()
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "appsettings.demo.json");

            if (!File.Exists(filePath))
            {
                string defaultJson = """
                {
                  "Application": {
                    "Name": "Enterprise Demo",
                    "Environment": "Development"
                  }
                }
                """;
                File.WriteAllText(filePath, defaultJson);
            }

            string json = File.ReadAllText(filePath);
            AppSettings? config = JsonSerializer.Deserialize<AppSettings>(json);

            Console.WriteLine($"App Name: {config?.Application?.Name}");
            Console.WriteLine($"Environment: {config?.Application?.Environment}");
        }

        private class AppSettings
        {
            public ApplicationSection? Application { get; set; }
        }

        private class ApplicationSection
        {
            public string? Name { get; set; }
            public string? Environment { get; set; }
        }
    }
}
