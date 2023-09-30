using System;

class Program
{
    private static string _line = "";

    static void Main(string[] args)
    {
        Reference reference = new("Proverbs",3,5);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding";
        Scripture scripture = new(reference,scriptureText);
        
        List<int> randomList = new List<int>();
        scripture.PopulateList(randomList);

        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress 'enter' to continue or type 'quit' to finish:");

        while (Continue(Console.ReadKey()))
        { 
            _line = "";

            if(randomList.Count == 0)
            {
                scripture.RevealAllScriptures();
                scripture.PopulateList(randomList);
            } 
            scripture.HideRandomWords(scripture.ReturnRandomNumber(randomList));
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress 'enter' to continue or type 'quit' to finish:");      
        }
            
    }

    private static bool Continue(ConsoleKeyInfo key)
    {
        if (key.Key == ConsoleKey.Enter) return true;

        _line += key.KeyChar;
        if (_line == "quit") return false;

        return Continue(Console.ReadKey());
    }
}