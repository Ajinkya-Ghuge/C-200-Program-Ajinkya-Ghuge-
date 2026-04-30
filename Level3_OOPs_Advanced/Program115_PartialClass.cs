using System;

namespace Level3_OOPs_Advanced
{
    public partial class Program115_PartialClass
    {
        public static void Run()
        {
            Employee employee = new Employee(1, "Ajinkya");
            employee.ShowBasicInfo();
            employee.ShowDepartment();
        }

        private partial class Employee
        {
            public int Id { get; }
            public string Name { get; }

            public Employee(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public void ShowBasicInfo()
            {
                Console.WriteLine($"Id: {Id}, Name: {Name}");
            }
        }
    }
}
