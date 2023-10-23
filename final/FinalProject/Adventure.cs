public class Adventure
{
    private string _name;
    private string _description;
    private int _scenarioTracker = 0;
    private string _scenarioOne;

    private List<Monster> _monsters = new List<Monster>();

    public void CreateAdventure(int selection)
    {
        switch(selection)
        {
            case 1:
            {
                //The Abandoned Castle
                break;
            }
            case 2:
            {
                //The Dark Forest
                break;
            }
            case 3:
            {
                //The Old Mill
                break;
            }
        }
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