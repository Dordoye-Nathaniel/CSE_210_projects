using System;

public class Cycling : Activity
{
    private double _speed;

    public double Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed / 60) * Minutes;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetActivityName()
    {
        return "Cycling";
    }
}