using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        prompt.AddDefaultPrompts();
        // SetJournal();
        // journal.DisplayAll();

        //please select one of the following choices:
        //1. Write
        //2. Display
        //3. Load
        //4. Save
        //5. Quit
        //What would you like to do?

        int selection = 1;
        while(selection != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            selection = Int32.Parse(Console.ReadLine());

            switch(selection)
            {
                case 1:
                {
                    //write to file
                    string randomPrompt = prompt.GetRandomPrompt();
                    Console.Write($"{randomPrompt}\n>");
                    string newEntry = Console.ReadLine();


                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToString("MM/dd,yyyy HH:mm");
                    entry._promptText = randomPrompt;
                    entry._entryText = newEntry;

                    journal.AddEntry(entry);                    

                    break;
                }
                case 2:
                {
                    //display
                    journal.DisplayAll();
                    //Console.WriteLine("case 2 display");
                    break;
                }
                case 3:
                {
                    //load
                    Console.WriteLine("case 3 load");
                    break;
                }
                case 4:
                {
                    //save
                    Console.WriteLine("case 4 save");
                    break;
                }                
            }
        }  
        
        
        // void SetJournal()
        // {
        //     Console.Write("Would you like to add a new entry? 'y' or 'n': ");
        //     string yesNo = Console.ReadLine();
        //     while (yesNo == "y")
        //     {
        //         PromptGenerator prompt = new PromptGenerator();
        //         prompt.AddDefaultPrompts();
        //         string entryPrompt = prompt.GetRandomPrompt();
        //         Console.WriteLine("********* This is a new journal entry *********");
        //         Console.WriteLine($"Prompt: {entryPrompt}");
        //         string entry = Console.ReadLine();

        //         Entry journalEntry = new Entry()
        //         {
        //             _date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
        //             _promptText = entryPrompt,
        //             _entryText = entry
        //         };

        //         journal.AddEntry(journalEntry);
                
        //         Console.WriteLine("Save file as: ");
        //         string fileName = Console.ReadLine();
                
        //         journal.SaveToFile(fileName);
                
        //         Console.Write("would you like to add another entry?\n'y' or 'n': ");
        //         yesNo = Console.ReadLine();
        //     }
        // }
    }
}