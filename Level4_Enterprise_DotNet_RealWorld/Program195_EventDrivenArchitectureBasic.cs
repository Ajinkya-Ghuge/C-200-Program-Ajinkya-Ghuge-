using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program195_EventDrivenArchitectureBasic
    {
        public static void Run()
        {
            OrderPlaced orderPlaced = new OrderPlaced("SO-500");
            Console.WriteLine($"Event published: {orderPlaced.OrderNumber}");
            Console.WriteLine("Inventory service and billing service consume the event.");
        }

        private record OrderPlaced(string OrderNumber);
    }
}
