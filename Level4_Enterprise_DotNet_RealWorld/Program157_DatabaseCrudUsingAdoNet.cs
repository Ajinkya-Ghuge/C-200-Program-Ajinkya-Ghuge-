using System;
using System.Data;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program157_DatabaseCrudUsingAdoNet
    {
        public static void Run()
        {
            DataTable employees = new DataTable("Employees");
            employees.Columns.Add("Id", typeof(int));
            employees.Columns.Add("Name", typeof(string));

            employees.Rows.Add(1, "Ajinkya");
            employees.Rows.Add(2, "Sneha");

            Console.WriteLine("ADO.NET style CRUD with DataTable");
            foreach (DataRow row in employees.Rows)
            {
                Console.WriteLine($"{row["Id"]} - {row["Name"]}");
            }

            employees.Rows[0]["Name"] = "Ajinkya Ghuge";
            employees.Rows[1].Delete();
            employees.AcceptChanges();

            Console.WriteLine("After update/delete:");
            foreach (DataRow row in employees.Rows)
            {
                Console.WriteLine($"{row["Id"]} - {row["Name"]}");
            }
        }
    }
}
