public class Comment
{
    public string _commenterName { get; private set; }
    public string _text { get; private set; }

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public override string ToString()
    {
        return $"{_commenterName}: {_text}";
    }
}