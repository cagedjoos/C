public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _status = false;
    }

    public SimpleGoal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status;
    }

    public override void CreateIndividualGoal()
    {
        CreateBaseGoal();
    }

    public override void RecordEvent()
    {
        if (_status == false) {
            _status = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        if (_status == true) {
            return true;
        } else {
            return false;
        }
    }

    public override void ListGoal()
    {
        string symbol = "";
        bool status = IsComplete();
        if (status == true) {
            symbol = "X";
        } else {
            symbol = " ";
        }
        Console.Write($"[{symbol}] {_name} ({_description})");
    }

    public override void ListGoalName()
    {
        Console.Write($"{_name}");
    }
    
    public override int CalculateTotalPoints()
    {
        bool status = IsComplete();
        int totalPoints = 0;
        if (status == true) {
            totalPoints = _points;
        } else {
            totalPoints = 0;
        }
        return totalPoints;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"SimpleGoal:{_name},{_description},{_points},{IsComplete().ToString()}";
        return line;
    }
}