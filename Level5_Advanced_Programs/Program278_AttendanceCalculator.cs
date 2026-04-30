using System;

class Program278_AttendanceCalculator
{
    static void Main()
    {
        Console.Write("Enter total working days: ");
        int total = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter days present: ");
        int present = Convert.ToInt32(Console.ReadLine());
        
        double percentage = (present * 100.0) / total;
        Console.WriteLine($"Attendance: {percentage:F2}%");
    }
}