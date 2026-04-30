using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program165_UnitTestingUsingNUnit
    {
        public static void Run()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Subtract(10, 4);

            bool passed = result == 6;
            Console.WriteLine("[NUnit Style Test]");
            Console.WriteLine(passed ? "Assert.That passed" : "Assert.That failed");
        }

        private class Calculator
        {
            public int Subtract(int a, int b) => a - b;
        }
    }
}
