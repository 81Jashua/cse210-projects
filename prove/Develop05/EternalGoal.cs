public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
    {        
    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{GetName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }    
}