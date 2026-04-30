using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program179_MessageQueueUsingRabbitMqBasic
    {
        public static void Run()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("OrderCreated");
            queue.Enqueue("PaymentReceived");

            Console.WriteLine($"Published: {queue.Dequeue()}");
            Console.WriteLine($"Published: {queue.Dequeue()}");
        }
    }
}
