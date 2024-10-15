public class MathAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textBook, string problems, string name, string topic): base(name, topic)
    {
        _textbookSection = textBook;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return _textbookSection + " " +  _problems;
    }
}