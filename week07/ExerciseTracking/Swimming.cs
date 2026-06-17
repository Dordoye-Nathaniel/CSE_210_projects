using System;

public class Swimming : Activity
{
    private int _laps;

    public int Laps
    {
        get { return _laps; }
        set { _laps = value; }
    }

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50.0 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }

    public override string GetActivityName()
    {
        return "Swimming";
    }
}