public class EternalGoal : Goal
{
    private int _count;

    public EternalGoal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _count = 0;
    }
    public EternalGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _count = 0;
    }
    public override void CreateIndividualGoal()
    {
        CreateBaseGoal();
    }
    
    public override void ListGoal()
    {
        Console.Write($"[ ] {_name} ({_description})");
    }

    public override void ListGoalName()
    {
        Console.Write($"{_name}");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"EternalGoal:" + _name + "," + _description + "," + _points.ToString();
        return line;
    }

    public override void RecordEvent()
    {
        _count ++;
    }
    public override int CalculateTotalPoints()
    {
        int points = _points;
        return points;
    }
}