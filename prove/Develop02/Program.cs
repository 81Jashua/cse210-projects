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
                    //write to journal
                    string randomPrompt = prompt.GetRandomPrompt();
                    Console.Write($"{randomPrompt}\n>");
                    string newEntry = Console.ReadLine();


                    Entry entry = new Entry()
                    {
                        _date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
                        _promptText = randomPrompt,
                        _entryText = newEntry    
                    };
                    journal.AddEntry(entry);            
                    break;
                }
                case 2:
                {
                    //display entry's in journal
                    journal.DisplayAll();
                    break;
                }
                case 3:
                {
                    //load
                    Console.WriteLine("What is the filename?");
                    string fileName = Console.ReadLine();
                    journal.LoadFromFile(fileName, journal);
                    break;
                }
                case 4:
                {
                    //save
                    Console.WriteLine("What is the name of the file?");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    break;
                }                
            }
        }
    }
}