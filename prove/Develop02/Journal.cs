public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // Add a new entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all entries
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    // Save to file
    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                // Use the getter properties to access values
                sw.WriteLine($"{entry.Date},{entry.PromptText},{entry.EntryText}");
            }
        }
    }

    // Load from file
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (var line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }
    }
}
