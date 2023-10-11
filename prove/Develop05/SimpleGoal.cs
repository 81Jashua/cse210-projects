public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {        
    }
        
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string status = "[ ]";
        if (IsComplete() == true)
        {
            status = "[X]";
        }
        
        return $"{status} {GetName()} ({GetDescription()})";
    }    
}