public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _status;

    public Goal() 
    {
        _name = "";
        _description = "";
        _points = 0;
        _status = false;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    protected void CreateBaseGoal() 
    {   
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = (Console.ReadLine());
        _points = Convert.ToInt32(goalPoints);

        _status = false;
    }

    public virtual string SaveGoal()
    {
        string line = "";
        return line;
    }

    public virtual void CreateIndividualGoal()
    {

    }

    public virtual void RecordEvent() 
    {

    }

    public virtual bool IsComplete() 
    {
        return false;
    }

    public virtual void ListGoal() 
    {

    }

    public virtual void ListGoalName()
    {

    }

    public virtual int CalculateTotalPoints()
    {
        return 0;
    }
}