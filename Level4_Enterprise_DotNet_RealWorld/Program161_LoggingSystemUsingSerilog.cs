using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program161_LoggingSystemUsingSerilog
    {
        public static void Run()
        {
            List<string> logs = new List<string>
            {
                "[Information] Application started",
                "[Warning] Disk usage is high",
                "[Error] Failed to connect to database"
            };

            Console.WriteLine("Serilog-style structured logging demo");
            foreach (string log in logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
