public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _accumulatedPoints = 0;

    public int GetAccumulatedPoints() {

        int points = _accumulatedPoints;
        return points;

    }
    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int totalPoints = GetAccumulatedPoints();
            outputFile.WriteLine(totalPoints.ToString());
            
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear(); 

        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _accumulatedPoints = Convert.ToInt32(lines[0]);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if (parts[0] == "SimpleGoal") {

                SimpleGoal simple = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                addGoal(simple);
                continue;             

            } else if (parts[0] == "EternalGoal") {

                EternalGoal eternal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                addGoal(eternal);
                continue;
            } else if (parts[0] == "ChecklistGoal") {
                
                ChecklistGoal checklist = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                addGoal(checklist);
                continue;
            }
        }

    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++) {
            Console.Write($"{i + 1}. ");
            _goals[i].ListGoal();
            Console.Write("\n");
        }
        Console.WriteLine();
    }

    public void addGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int CalculatetotalPoints()
    {
        int totalPoints = _accumulatedPoints;
        foreach(Goal goal in _goals) {
            totalPoints += goal.CalculateTotalPoints();
        }

        _accumulatedPoints = totalPoints;

        return totalPoints;
    }

    public void RecordEvent()
    {
        string goalIndex = "";
        for (int i = 0; i < _goals.Count(); i++) {
            Console.Write($"{i + 1}. ");
            _goals[i].ListGoalName();
            Console.Write("\n");
        }
        Console.WriteLine();
        Console.Write("Which goal did you accomplish? ");
        goalIndex = Console.ReadLine();
        int goalIndexInt = Convert.ToInt32(goalIndex) - 1;

        if (_goals[goalIndexInt].IsComplete() == false) {

            _goals[goalIndexInt].RecordEvent();

            int pointsEarned = _goals[goalIndexInt].CalculateTotalPoints();

            _accumulatedPoints += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned.ToString()} points!");
            Console.WriteLine($"You now have {_accumulatedPoints} points");

        } else {

            Console.WriteLine("You have already completed this goal.");

        }
    }
}