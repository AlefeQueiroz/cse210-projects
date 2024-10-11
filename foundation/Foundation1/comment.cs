// Class to represent a comment on a video
class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    // Constructor to initialize the commenter's name and the comment text
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }

    // Method to display the comment
    public void Display()
    {
        Console.WriteLine($"{CommenterName}: {Text}");
    }
}
