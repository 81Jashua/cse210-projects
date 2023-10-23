public class Adventure
{
    private string _name;
    private string _description;
    private int _scenario = 0;
    private List<string> _scenarios;
    private List<Monster> _monsters = new List<Monster>();

    public void CreateAdventure(int selection)
    {
        switch(selection)
        {
            case 1:
            {
                //The Abandoned Castle
                SetName(" The Abandoned Castle");
                SetDescription(AdventureDescription(selection));
                DisplayAdventure();
                                
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
        _scenario += 1;
    }
    public void AddMonster(Monster monster)
    {
        _monsters.Add(monster);
    }
    public string AdventureDescription(int selection)
    {
        string description = "";
        switch(selection)
        {
            case 1:
            {
                //Abandoned Castle description
                description = @"Once a beautiful castle known for its riches.\nBuilt into the side of the mountain for defenses
             they discovered gold. \nDiving deeper and deeper into the mountain they awoke something. 
             For years no news came. Recently there have been reports of evil creatures attacking farms.\n
             Your quest is to find the problem and save the town.";
                break;
            }
            case 2:
            {
                //The Dark Forest description
                description = @"  blah blah";
                break;
            }
            case 3:
            {
                //The Old Mill description
                description = @"  blah blah";
                break;
            }        
        }
        return description;
    }
    public void GetScenario()
    {
        
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void DisplayAdventure()
    {
        Console.WriteLine("=========================================================");
        Console.WriteLine($"Adventure:  {GetName()}\nDescription: {GetDescription()}");
        Console.WriteLine("=========================================================");
    }
}