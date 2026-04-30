using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program181_MicroservicesCommunicationBasic
    {
        public static void Run()
        {
            string orderServiceResponse = "Order accepted";
            string inventoryServiceResponse = "Stock reserved";

            Console.WriteLine(orderServiceResponse);
            Console.WriteLine(inventoryServiceResponse);
        }
    }
}
