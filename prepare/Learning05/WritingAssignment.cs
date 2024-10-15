public class WritingAssignment:Assignment
{
    private string _title;

    public WritingAssignment(string title, string name, string topic): base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string name = GetName();

        return $"{_title} by {name}";
    }
}