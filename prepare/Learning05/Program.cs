using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Matthew", "Science");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment("Section 7.3", "Problems 8-19", "Henry Dunne", "Science");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("The Causes of World War II", "Johnny Depp", "English");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}