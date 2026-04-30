using System;
using System.Collections.Generic;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program194_CqrsPatternImplementation
    {
        public static void Run()
        {
            List<string> readModel = new List<string>();
            CreateProductCommand command = new CreateProductCommand("Laptop");
            HandleCommand(command, readModel);
            string result = HandleQuery(new GetProductsQuery(), readModel);

            Console.WriteLine(result);
        }

        private static void HandleCommand(CreateProductCommand command, List<string> readModel)
        {
            readModel.Add(command.Name);
        }

        private static string HandleQuery(GetProductsQuery _, List<string> readModel)
        {
            return $"Products: {string.Join(", ", readModel)}";
        }

        private record CreateProductCommand(string Name);
        private record GetProductsQuery;
    }
}
