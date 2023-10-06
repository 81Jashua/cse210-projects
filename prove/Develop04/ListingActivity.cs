public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
    }
    
    public void Run()
    {
        DisplayStartingMessage();
        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();
        Console.WriteLine($"Get ready...");
        Pause();
        SetPrompts();
        GetRandomPrompt();
        //Pause();
        Test();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(_prompts.Count);
        string tempPrompt = _prompts[randomPrompt];
        _prompts.RemoveAt(randomPrompt);
        Console.WriteLine($"List as many responses you can to the following prompt:\n---{tempPrompt}---\nYou may begin in:");
        ShowCountDown(5);
    }

    public void SetPrompts()
    {
        string prompt1 = "Who are people that you appreciate?";
        string prompt2 = "What are personal strengths of yours?";
        string prompt3 = "Who are people that you have helped this week?";
        string prompt4 = "When have you felt the Holy Ghost this month?";
        string prompt5 = "Who are some of your personal heroes?";

        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);
        _prompts.Add(prompt5);
    }

    public List<string> GetListFromUser(List<string> list)
    {
        return list;
    }

    public void Test()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        //Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        do 
        {
            Console.Write("> ");
            string bar = Console.ReadLine();
            _count += 1;
            currentTime = DateTime.Now;
        }
        while (currentTime < futureTime);
        

        // if (currentTime < futureTime)
        // {
        //     Console.WriteLine("> ");
        //     string bar = Console.ReadLine();
        // }
        // while (currentTime < futureTime)
        // {
            //Console.WriteLine("> ");
            // if (Console.ReadKey().Key == ConsoleKey.Enter)
            // {
            //     _count += 1;
            //     //string response = Console.ReadLine()

            // }
            //Console.WriteLine("We have not arrived at our future time yet...");
            //Thread.Sleep(1000);
        //     currentTime = DateTime.Now;
        // }
        Console.WriteLine($"You wrote {_count} messages!");
        Pause();        
    }

    // public void Continue()
    // {
        
    //     while (Console.ReadKey().Key != ConsoleKey.Enter)
    //     {
    //         Continue();
    //     }
    // }
}