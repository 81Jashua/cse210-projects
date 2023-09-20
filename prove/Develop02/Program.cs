using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompts = new PromptGenerator();
        prompts.AddDefaultPrompts();
        //prompts.GetAllPrompts();

        Console.WriteLine(prompts.GetRandomPrompt());

        string newPrompt = prompts.GetRandomPrompt();
        Entry entryOne = new Entry
        {
            _date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
            _promptText = newPrompt,
            _entryText = "testing my first prompt."
        };

        entryOne.Display();
    }
}