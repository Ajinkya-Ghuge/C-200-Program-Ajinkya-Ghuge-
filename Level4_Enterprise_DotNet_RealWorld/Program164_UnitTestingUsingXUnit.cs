using System;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program164_UnitTestingUsingXUnit
    {
        public static void Run()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(5, 7);

            bool passed = result == 12;
            Console.WriteLine("[xUnit Style Test]");
            Console.WriteLine(passed ? "Fact passed" : "Fact failed");
        }

        private class Calculator
        {
            public int Add(int a, int b) => a + b;
        }
    }
}
