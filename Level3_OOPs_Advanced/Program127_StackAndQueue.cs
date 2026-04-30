using System;
using System.Collections.Generic;

namespace Level3_OOPs_Advanced
{
    public class Program127_StackAndQueue
    {
        public static void Run()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine($"Stack pop: {stack.Pop()}");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            Console.WriteLine($"Queue dequeue: {queue.Dequeue()}");
        }
    }
}
