using System;

class Program277_StudentGradeCalculator
{
    static void Main()
    {
        Console.Write("Enter marks for 5 subjects: ");
        int[] marks = new int[5];
        int total = 0;
        
        for (int i = 0; i < 5; i++)
        {
            marks[i] = Convert.ToInt32(Console.ReadLine());
            total += marks[i];
        }
        
        double avg = total / 5.0;
        char grade = avg >= 90 ? 'A' : avg >= 80 ? 'B' : avg >= 70 ? 'C' : avg >= 60 ? 'D' : 'F';
        
        Console.WriteLine($"Average: {avg:F2}%, Grade: {grade}");
    }
}