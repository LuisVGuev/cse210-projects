public class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }

    // The Comment object
    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }
}
