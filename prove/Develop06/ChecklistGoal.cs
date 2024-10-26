public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _steps;
    private int _count;

    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string name, string description, int points, int bonus, int steps, int count)
    {
        _name = name;
        _description = description;
        _points = points;
        _bonus = bonus;
        _steps = steps;
        _count = count;
    }

    public override void CreateIndividualGoal()
    {
        CreateBaseGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringChecklistSteps = Console.ReadLine();
        _steps = Convert.ToInt32(stringChecklistSteps);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonus = Console.ReadLine();
        _bonus = Convert.ToInt32(bonus);

        _count = 0;

    }

    public override bool IsComplete() 
    {
        if (_count >= _steps) {
            return true;
        } else {
            return false;
        }
    }
    
    public override void RecordEvent()
    {
        _count ++;
    }

    public override int CalculateTotalPoints()
    {
        int points = 0;

        points = _count * _points;

        bool status = IsComplete();

        if (status == true) {
            points += _bonus;
        }

        return points;

    }

    public override void ListGoal()
    {
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }

        Console.Write($"[{statusSymbol}] {_name} ({_description}) -- Currently Completed {_count}/{_steps}");
    }

    public override void ListGoalName()
    {
        Console.Write($"{_name}");
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"ChecklistGoal:" + _name + "," + _description + "," + _points.ToString() + "," + _bonus.ToString() + "," + _steps.ToString() + "," + _count.ToString();
        return line;
    }

}