// Class to represent a YouTube video
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Video length in seconds
    private List<Comment> Comments { get; set; } // List of comments

    // Constructor to initialize video details and create an empty list of comments
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to get the number of comments on the video
    public int GetNumComments()
    {
        return Comments.Count;
    }

    // Method to display video information along with comments
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {Length} seconds");
        Console.WriteLine($"Number of comments: {GetNumComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}
