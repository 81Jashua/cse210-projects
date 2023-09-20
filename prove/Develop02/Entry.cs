public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {

    }

    public void Display()
    {
        Console.WriteLine($"-----New entry-----\nDate: {_date}\nJournal prompt: {_promptText}\nJournal Entry: {_entryText}");
    }
}