public class ProgressGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ProgressGoal(
        string shortName,
        string description,
        int points,
        int target,
        int bonus,
        int amountCompleted = 0
    ) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            return Points + _bonus;
        }

        return Points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";

        return $"{checkbox} {ShortName} ({Description}) " +
               $"-- Progress: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ProgressGoal:{ShortName},{Description},{Points}," +
               $"{_target},{_bonus},{_amountCompleted}";
    }
}