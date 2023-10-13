public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {        
    }
        
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {       
        return $"SimpleGoal,{GetName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }    
}