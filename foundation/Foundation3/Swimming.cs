public class Swimming:Activity
{
    private double _laps;

    public double GetLaps(double laps)
    {
        _laps = laps;
        return _laps;
    }

    public override double GetDistance()
    {
        _distance = _laps * 50 / 1000 * 0.62;
        return _distance;
    }

    public override double GetSpeed()
    {
        _speed = (_distance / _minutes) * 60;
        return _speed;
    }

    public override double GetPace()
    {
        _pace = _minutes / _distance;
        return _pace;
    }

    public override string GetName()
    {
        _name = "Swimming";
        return _name;
    }

    public override void Calculate()
    {
        GetDistance();
        GetSpeed();
        GetPace();
        GetName();
    }
}