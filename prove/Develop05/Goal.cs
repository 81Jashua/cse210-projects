public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public void SetPoints(string points)
    {
        _points = points;
    }    

    public abstract void RecordEvent();


    public abstract bool IsComplete();

    public abstract void SetComplete(bool value);

    public virtual string GetDetailsString()
    {
        string status = "[ ]";
        if (IsComplete() == true)
        {
            status = "[X]";
        }
        
        return $"{status} {GetName()} ({GetDescription()})";
    }

    public abstract string GetStringRepresentation();
}