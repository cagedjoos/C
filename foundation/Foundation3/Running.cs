public class Running:Activity
{
    public double GetDistance(double distance)
    {
        _distance = distance;
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
        _name = "Running";
        return _name;
    }

    public override void Calculate()
    {
        GetSpeed();
        GetPace();
        GetName();
    }
}