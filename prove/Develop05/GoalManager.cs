public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    //GoalManager(){}

    public int GetScore()
    {
        return _score;
    }

    public void SetScore()
    {
        _score += 1;
    }

    public List<Goal> GetList()
    {
        return _goals;
    }

    public void SetList(Goal goal)
    {
        _goals.Add(goal);
    }

    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Your goals are:");
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        
        int selection = Int32.Parse(Console.ReadLine());
        switch(selection)
        {
            case 1:
            {
                Console.WriteLine("\n Congradulation you have choosen to create a Simple Goal.");
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                SetList(simpleGoal);
                break;
            }
            case 2:
            {
                Console.WriteLine("\n Congradulation you have choosen to create a Eternal Goal.");
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();

                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                SetList(eternalGoal);
                break;
            }
            case 3:
            {
                Console.WriteLine("\n Congradulation you have choosen to create a Checklist Goal.");
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();
                Console.Write("What is the bonus for completing your goal? ");
                int bonus = int.Parse(Console.ReadLine());
                Console.Write("How many in the series to complete your goal? ");
                int target = int.Parse(Console.ReadLine());

                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, bonus, target);
                SetList(checkListGoal);
                break;
            }
        }
    }
    public void RecordEvent()
    {

    }
    public void SaveGoals(string file)
    {
        Console.WriteLine("What is the name of the file?");
        string fileName = file;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(GetScore());
            foreach (Goal goal in _goals)
            {
                
                //outputFile.WriteLine($"{goal},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.IsComplete()}");
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals()
    {
        // journal._entries.Clear();
        // string filename = file;
        // string[] lines = System.IO.File.ReadAllLines(filename);

        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split(",");
            
        //     Console.WriteLine($"Date: {parts[0]} Prompt: {parts[1]}\n{parts[2]}");
        //     Entry entry = new Entry()
        //     {
        //         _date = parts[0],
        //         _promptText = parts[1],
        //         _entryText = parts[2]
        //     };
        //     journal.AddEntry(entry);
    }
    public void DisplayScore()
    {
        Console.WriteLine($"You have {GetScore()} points.\n");
    }
}