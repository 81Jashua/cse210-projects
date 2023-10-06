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
        Pause();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomPrompt = random.Next(_prompts.Count);
        string tempPrompt = _prompts[randomPrompt];
        _prompts.RemoveAt(randomPrompt);
        Console.WriteLine(tempPrompt);
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
}