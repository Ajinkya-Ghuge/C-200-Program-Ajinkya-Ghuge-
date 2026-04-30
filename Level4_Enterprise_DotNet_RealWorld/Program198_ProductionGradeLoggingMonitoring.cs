using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program198_ProductionGradeLoggingMonitoring
    {
        public static void Run()
        {
            Dictionary<string, object> telemetry = new Dictionary<string, object>
            {
                ["TraceId"] = Guid.NewGuid(),
                ["Service"] = "OrderApi",
                ["StatusCode"] = 200,
                ["DurationMs"] = 42
            };

            foreach (KeyValuePair<string, object> item in telemetry)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
