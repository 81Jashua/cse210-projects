public class SimpleGoal : Goal
{
    private bool _isComplete;

    private SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {        
    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }    
}