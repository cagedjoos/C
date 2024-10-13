public class Comment
{
    public string _commentText;
    public string _commentName;

    Video v3 = new Video();

    public void DisplayComment()
    {
        Console.WriteLine($"{_commentName}: {_commentText}");
    }
}