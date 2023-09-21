using System;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-----=== Hello Welcome to W02 Journal Program ===-----");
        Journal journal = new Journal();
        SetJournal();
        journal.DisplayAll();

        void SetJournal()
        {
            Console.Write("Would you like to add a new entry? 'y' or 'n': ");
            string yesNo = Console.ReadLine();
            while (yesNo == "y")
            {
                PromptGenerator prompt = new PromptGenerator();
                prompt.AddDefaultPrompts();
                string entryPrompt = prompt.GetRandomPrompt();
                Console.WriteLine("********* This is a new journal entry *********");
                Console.WriteLine($"Prompt: {entryPrompt}");
                string entry = Console.ReadLine();

                Entry journalEntry = new Entry()
                {
                    _date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
                    _promptText = entryPrompt,
                    _entryText = entry
                };

                journal.AddEntry(journalEntry);
                Console.Write("would you like to add another entry?\n'y' or 'n': ");
                yesNo = Console.ReadLine();
            }
        }
    }
}