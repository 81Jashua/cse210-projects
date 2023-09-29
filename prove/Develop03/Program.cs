using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("Proverbs",3,5);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding";
        Scripture scripture = new(reference,scriptureText);
        Random random = new Random();
        ///Test
        List<int> randomList = new List<int>();
        scripture.PopulateList(randomList);
        ///

        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress 'enter' to continue or type 'quit' to finish:");

        while (Console.ReadKey().Key == ConsoleKey.Enter)
        { 
            scripture.HideRandomWords(scripture.ReturnRandomNumber(randomList));
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress 'enter' to continue or type 'quit' to finish:");            
        }
    }    
}