using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program199_EnterpriseExceptionHandlingStrategy
    {
        public static void Run()
        {
            try
            {
                throw new ApplicationException("Database timeout");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine($"Logged exception: {ex.Message}");
                Console.WriteLine("Returned standardized error response to client.");
            }
        }
    }
}
