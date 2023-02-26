using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();

        Console.WriteLine(summary);

        MathAssignment mathAssignment = new MathAssignment("Section", "Fractions", "7.3", "8-19");
        //string summary = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        //Console.WriteLine(summary);
        Console.WriteLine(homeworkList);


    }
}
