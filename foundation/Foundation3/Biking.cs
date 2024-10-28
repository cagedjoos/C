public class Biking:Activity
{
    private double _hour;

    public double GetSpeed(double speed)
    {
        _speed = speed;
        return _speed;
    }

    public override double GetDistance()
    {
        _distance = _speed * _hour;
        return _distance;
    }

    public override double GetPace()
    {
        _pace = MinutesPerHour / _speed;
        return _pace;
    }

    public double GetHour()
    {
        _hour = _minutes / MinutesPerHour;
        return _hour;
    }

    public override string GetName()
    {
        _name = "Biking";
        return _name;
    }

    public override void Calculate()
    {
        GetHour();
        GetDistance();
        GetPace();
        GetName();
    }
}