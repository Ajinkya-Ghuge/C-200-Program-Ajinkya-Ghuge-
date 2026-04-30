using System;
using System.Collections.Generic;

namespace Level3_OOPs_Advanced
{
    public class Program125_CollectionsList
    {
        public static void Run()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };
            fruits.Add("Orange");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
