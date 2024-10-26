using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";

        GoalManager manager = new GoalManager();

        Console.WriteLine("Welcome to Eternal Quest!");
        Thread.Sleep(2000);
        Console.WriteLine("In this game, you will make goals and earn points by completing them!");
        Thread.Sleep(3000);
        while (response != "6")
        {
            int points = manager.GetAccumulatedPoints();

            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            response = Console.ReadLine();

            string goalResponse = "";
            if (response == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create?");
                goalResponse = Console.ReadLine();

                if (goalResponse == "1")
                {
                    SimpleGoal simple = new SimpleGoal();
                    simple.CreateIndividualGoal();
                    manager.addGoal(simple);
                }
                else if (goalResponse == "2")
                {
                    EternalGoal eternal = new EternalGoal();
                    eternal.CreateIndividualGoal();
                    manager.addGoal(eternal);
                }
                else if (goalResponse == "3")
                {
                    ChecklistGoal checklist = new ChecklistGoal();
                    checklist.CreateIndividualGoal();
                    manager.addGoal(checklist);
                }
                else
                {
                    Console.WriteLine("That is not an available goal. Please try again.");
                }
            }
            else if (response == "2")
            {
                manager.ListGoals();
            }
            else if (response == "3")
            {
                manager.SaveGoals();
            }
            else if (response == "4")
            {
                manager.LoadGoals();
            }
            else if (response == "5")
            {
                manager.RecordEvent();
            }
            else if (response == "6")
            {
                Console.WriteLine("Thanks for participating!");
                break;
            }
            else
            {
                Console.WriteLine("That option is not available, please try again.");
            }
        }
    }
}