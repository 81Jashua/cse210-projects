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
            
            // var random = new Random();
            // int randomPrompt = random.Next(_prompts.Count);
            // return _prompts[randomPrompt];
            //int foo = random.Next(scripture.getWords());
            //scripture.HideRandomWords(foo);            
            scripture.HideRandomWords(scripture.ReturnRandomNumber(randomList));
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress 'enter' to continue or type 'quit' to finish:");
            foreach(int car in randomList)
            {
                Console.Write($"{car},");
            }
        }

        ///Temp code
        // void PopulateList(List<int> list)
        // {
        //     int foo = scripture.getWords();
        //     for (int i = 0; i < foo; i++)
        //     {
        //         list.Add(i);                
        //     }
        //     foreach(int car in list)
        //     {
        //         Console.Write($"{car},");
        //     }
        // }
        
        // int ReturnRandomNumber(List<int> list)
        // {
        //     int tempCount = list.Count();
        //     int foop = random.Next(tempCount);
        //     int hoop = list[foop];
        //     list.RemoveAt(foop);
        //     return hoop;
        // }
    }    
}