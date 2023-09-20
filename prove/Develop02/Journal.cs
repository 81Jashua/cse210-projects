public class Journal
{
    List<Entry> _entries = new List<Entry>();

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
            
        }
    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }
}