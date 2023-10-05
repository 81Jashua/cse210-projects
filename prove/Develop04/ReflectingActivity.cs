public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description)
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
        SetQuestions();
        DisplayPrompt();
        Continue();
        DisplayQuestions();
        DisplayEndingMessage();
        Pause();
    }

    public string GetRandomPrompt()
    {
        var random = new Random();
        int randomPrompt = random.Next(_prompts.Count);
        return _prompts[randomPrompt];
    }

    public string GetRandomQuestion()
    {
        var random = new Random();
        int randomQuestion = random.Next(_questions.Count);
        string tempQuestion = _questions[randomQuestion];
        _questions.RemoveAt(randomQuestion);
        return tempQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Consider the following prompt:\n---{GetRandomPrompt()}---");
        Console.WriteLine("When you have something in mind press Enter to continue");        
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"Now ponder on each of the following questions as they are related to this experience.");
        int seconds = GetDuration();
        
        while (seconds > 0)
        {

            int setCount;
            if (seconds < 5)
                    {
                        setCount = seconds;
                    }
            else {setCount = 5;} 
            Console.WriteLine($"{GetRandomQuestion()}");
            ShowCountDown(setCount);

            seconds -= 5;
        }
    }

    public void SetQuestions()
    {
        string q1 = "Why was this experience meaningful to you?";
        string q2 = "Have you ever done anything like this before?";
        string q3 = "How did you get started?";
        string q4 = "How did you feel when it was complete?";
        string q5 = "What made this time different than other times when you were not as successful?";
        string q6 = "What is your favorite thing about this experience?";
        string q7 = "What could you learn from this experience that applies to other situations?";
        string q8 = "What did you learn about yourself through this experience?";
        string q9 = "How can you keep this experience in mind in the future?";

        _questions.Add(q1);
        _questions.Add(q2);
        _questions.Add(q3);
        _questions.Add(q4);
        _questions.Add(q5);
        _questions.Add(q6);
        _questions.Add(q7);
        _questions.Add(q8);
        _questions.Add(q9);
    }
    public void SetPrompts()
    {
        List<string> prompts = new List<string>();
        string prompt1 = "Think of a time when you stood up for someone else";
        string prompt2 = "Think of a time when you did something really difficult";
        string prompt3 = "Think of a time when you helped someone in need";
        string prompt4 = "Think of a time when you did something truly selfless";

        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);
    }

    public void Continue()
    {
        while (Console.ReadKey().Key != ConsoleKey.Enter)
        {
            Continue();
        }
    }
}