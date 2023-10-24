using System;

class Program
{
    static void Main(string[] args)
    {
        AdventureManager adventureManager = new AdventureManager();
        string selection = "1";
        while(selection == "1")
        {
            Console.WriteLine("Welcome to Adventure Quest");
            Console.WriteLine("  1. Start");
            Console.WriteLine("  2. Quit");
            selection = Console.ReadLine();
            adventureManager.Run();
        }
    }
}