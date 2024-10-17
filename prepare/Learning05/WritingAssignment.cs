public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Agora acessa diretamente o _studentName da classe base
        return $"{_title} by {_studentName}";
    }
}
