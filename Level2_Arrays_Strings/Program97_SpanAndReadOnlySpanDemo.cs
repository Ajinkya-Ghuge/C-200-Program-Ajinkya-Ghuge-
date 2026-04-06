using System;

namespace Level2_Arrays_Strings
{
    public class Program97_SpanAndReadOnlySpanDemo
    {
        public static void Main()
        {
            // Program 97: Demonstrate Span and ReadOnlySpan.
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Span can modify underlying array.
            Span<int> span = numbers.AsSpan(1, 3);
            span[0] = 999;

            // ReadOnlySpan allows read-only view.
            ReadOnlySpan<int> readOnly = numbers.AsSpan();

            Console.WriteLine("Array after Span modification:");
            foreach (int n in numbers) Console.Write(n + " ");
            Console.WriteLine();

            Console.WriteLine("ReadOnlySpan values:");
            for (int i = 0; i < readOnly.Length; i++) Console.Write(readOnly[i] + " ");
            Console.WriteLine();
        }

    }
}
