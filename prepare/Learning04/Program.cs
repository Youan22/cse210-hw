using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();

        Console.WriteLine(summary);

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7", "8-19");

        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homeworkList);

        

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string writingInfo = writingAssignment.GetWritingInformation();
        Console.WriteLine(summary);
        Console.WriteLine(writingInfo);


    }
}
