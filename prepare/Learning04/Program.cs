using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John", "C#");
        MathAssignment mathAssignment = new MathAssignment("John", "Math", "10.3", "12-23");
        WritingAssignment writingAssignment = new WritingAssignment("John", "C#", "A Cool Title");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}