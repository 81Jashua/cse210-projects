public class Adventure
{
    private string _name;
    private string _description;
    private int _scenarioTracker = 0;
    private string _scenarioOne;

    private List<Monster> _monsters = new List<Monster>();

    public Adventure(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void SetTracker()
    {
        _scenarioTracker += 1;
    }
    public void AddMonster(Monster monster)
    {
        _monsters.Add(monster);
    }
}