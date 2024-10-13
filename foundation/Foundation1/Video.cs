public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length = 0;
    public List<Comment> _comments = new List<Comment>();

    public void MakeComment(Comment c3)
    {
        _comments.Add(c3);
    }

    public void Display()
    {
        Console.WriteLine($"{_title}, {_author}, {_length} seconds");
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
        
    }
}