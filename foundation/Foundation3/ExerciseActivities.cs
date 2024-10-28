public class Activity
{
    protected const int MinutesPerHour = 60;

    protected double _minutes;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _name;
    
    public virtual double GetDistance()
    {
        return 0;
    }

    public double GetMinutes(double minutes)
    {
        _minutes = minutes;
        return _minutes;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetName()
    {
        return "";
    }

    public virtual void Calculate()
    {

    }

    public void GetSummary()
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine($"{dt.ToString("dd")} {dt.ToString("MMM")} {dt.ToString("yyyy")} {_name} ({_minutes} min)- Distance {_distance.ToString("0.0")} miles, Speed {_speed.ToString("0.0")} mph, Pace {_pace.ToString("0.0")} min per mile");
    }
}