using System;
using System.Text;

namespace Level2_Arrays_Strings
{
    public class Program69_StringBuilderDemo
    {
        public static void Main()
        {
            // Program 69: Demonstrate StringBuilder.
            StringBuilder sb = new StringBuilder();
            sb.Append("C#");
            sb.Append(" ");
            sb.Append("StringBuilder");
            sb.AppendLine(" Demo");
            sb.Replace("Demo", "Example");
            Console.WriteLine(sb.ToString());
        }

    }
}
