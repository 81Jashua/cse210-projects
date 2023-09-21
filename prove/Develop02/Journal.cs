using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = file;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file, Journal journal)
    {
        journal._entries.Clear();
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            
            Console.WriteLine($"Date: {parts[0]} Prompt: {parts[1]}\n{parts[2]}");
            Entry entry = new Entry()
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            journal.AddEntry(entry);
        }
    }
}