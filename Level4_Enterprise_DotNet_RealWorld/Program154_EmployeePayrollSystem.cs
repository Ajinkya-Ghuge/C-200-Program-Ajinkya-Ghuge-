using System;
using System.Collections.Generic;
using System.Linq;

namespace Level4_Enterprise_DotNet_RealWorld
{
    public class Program154_EmployeePayrollSystem
    {
        public static void Run()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Ajinkya", 30000m, 5000m),
                new Employee("Amit", 28000m, 4000m)
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - Net Pay: {employee.GetNetPay():C}");
            }

            Console.WriteLine($"Total payroll: {employees.Sum(employee => employee.GetNetPay()):C}");
        }

        private class Employee
        {
            public Employee(string name, decimal basicSalary, decimal allowance)
            {
                Name = name;
                BasicSalary = basicSalary;
                Allowance = allowance;
            }

            public string Name { get; }
            public decimal BasicSalary { get; }
            public decimal Allowance { get; }

            public decimal GetNetPay() => BasicSalary + Allowance;
        }
    }
}
