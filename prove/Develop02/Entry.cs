public class Entry
{
    // Private fields
    private string _date;
    private string _promptText;
    private string _entryText;

    // Constructor
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Public getter properties
    public string Date => _date;
    public string PromptText => _promptText;
    public string EntryText => _entryText;

    // Display method
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}\n");
    }
}
