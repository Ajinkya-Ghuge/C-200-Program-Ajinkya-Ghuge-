using System;

namespace Level3_OOPs_Advanced
{
    public class Program112_ReadonlyVsConst
    {
        public static void Run()
        {
            Config config = new Config("Production");
            Console.WriteLine($"Const value: {Config.CompanyName}");
            Console.WriteLine($"Readonly value: {config.EnvironmentName}");
        }

        private class Config
        {
            public const string CompanyName = "Contoso";
            public readonly string EnvironmentName;

            public Config(string environmentName)
            {
                EnvironmentName = environmentName;
            }
        }
    }
}
