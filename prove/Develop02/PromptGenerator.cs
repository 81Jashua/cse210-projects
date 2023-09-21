public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {

    }

    public void AddDefaultPrompts()
    {
        string promptOne = "What type of mood were you in today?";
        string promptTwo = "Did you recieve any promptings today?";
        string promptThree = "How are you coming along with your goals?";
        string promptFour = "Did you have any interesting conversations today";
        string promptFive = "How was work?";

        _prompts.Add(promptOne);
        _prompts.Add(promptTwo);
        _prompts.Add(promptThree);
        _prompts.Add(promptFour);
        _prompts.Add(promptFive);
    }
    
    public string GetRandomPrompt()
    {
        var random = new Random();
        int randomPrompt = random.Next(_prompts.Count);
        return _prompts[randomPrompt];
    }

    public void GetAllPrompts()
    {
        foreach(string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }
}