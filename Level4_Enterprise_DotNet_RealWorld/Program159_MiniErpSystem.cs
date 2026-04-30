using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program159_MiniErpSystem
    {
        public static void Run()
        {
            List<SalesOrder> orders = new List<SalesOrder>
            {
                new SalesOrder("SO-001", "Laptop", 2),
                new SalesOrder("SO-002", "Printer", 1)
            };

            Console.WriteLine("Mini ERP Orders");
            foreach (SalesOrder order in orders)
            {
                Console.WriteLine($"{order.OrderNumber} - {order.ProductName} - Qty: {order.Quantity}");
            }
        }

        private record SalesOrder(string OrderNumber, string ProductName, int Quantity);
    }
}
