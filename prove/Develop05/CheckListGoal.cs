public class CheckListGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public CheckListGoal(string shortName, string description, string points, int bonus, int target) : base(shortName, description, points)
    {
        _bonus = bonus;
        _target = target;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if (IsComplete() == true)
        {
            int bonus = int.Parse(GetPoints()) + _bonus;
            SetPoints(bonus.ToString());
        }
    }
    public override void SetComplete(bool value)
    {
        _amountCompleted = 0;        
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else {return false;}
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal,{GetName()},{GetDescription()},{GetPoints()},{GetAmountCompleted()},{GetTarget()},{GetBonus()},{IsComplete()}";
    }
    public override string GetDetailsString()
    {
        string status = "[ ]";
        if (IsComplete() == true)
        {
            status = "[X]";
        }
        
        return $"{status} {GetName()} ({GetDescription()} -- Currently completed: {GetAmountCompleted()}/{GetTarget()})";
    }    
}