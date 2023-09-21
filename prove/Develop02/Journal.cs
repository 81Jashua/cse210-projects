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
            outputFile.WriteLine($"Date: {entry._date}");
        }
    }

    public void LoadFromFile(string file)
    {

    }
}