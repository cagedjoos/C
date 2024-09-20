using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();

        int percent = int.Parse(grade);

        string lettergrade = "";
        
        if (percent >= 90)
        {
            lettergrade = "A";
        }
        else if (percent >= 80)
        {
            lettergrade = "B";
        }
        else if (percent >= 70)
        {
            lettergrade = "C";
        }
        else if (percent >= 60)
        {
            lettergrade = "D";
        }
        else
        {
            lettergrade = "F";
        }
        Console.WriteLine($"Your letter grade is {lettergrade}.");
    }
}