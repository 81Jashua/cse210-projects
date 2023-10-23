public class Scenarios
{
    private string _name;
    private string _description;
    private List<Monster> _monsters;

    public void Scenario(int adventure, int difficulty)
    {
        switch(adventure)
        {
            case 1:
            {
                string scenario = GetCastleEncounter(difficulty);
                break
            }
        }
    }


    public string GetCastleEncounter(int diffuculty)
    {
        List<string> encounter = new List<string>();
        switch(diffuculty)
        {
            case 1:
            {
                Console.WriteLine("Scenario 1:");
                Console.WriteLine(@"You decide to take the road. While traveling on the road you see an abandonded wagon.
                What do you do? type 'search' to search or 'ignore' to ignore");
                string descision = Console.ReadLine();
                if (descision == "search")
                {
                    Console.WriteLine("You've decided to search:");
                    Console.WriteLine("Roll the dice do see what happnes:");
                    
                }
                break;
            }
            case 2:
            {
                break;
            }
        }        
    }


}