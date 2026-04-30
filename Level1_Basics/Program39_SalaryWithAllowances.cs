using System;

namespace CSharpPrograms
{
    public class Program39_SalaryWithAllowances
    {
        public static void Main()
        {
            // Program 39: Salary with allowances
            Console.Write("Enter basic salary: ");
            double basic = Convert.ToDouble(Console.ReadLine());
            double hra = basic * 0.20; // House rent allowance
            double da = basic * 0.10;  // Dearness allowance
            double gross = basic + hra + da;
            Console.WriteLine($"HRA = {hra}, DA = {da}, Gross Salary = {gross}");
        }
    }
}

