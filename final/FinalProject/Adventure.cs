public class Adventure
{
    private string _name;
    private string _description;

    private List<Monster> _monsters = new List<Monster>();
    private List<string> _scenarios;

    public void SetName(string name)
    {
        _name = name;
    }
}