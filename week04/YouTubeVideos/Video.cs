using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; }
    public List<Comment> Comments { get; set; }

    // Initialize the Video object
    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        Comments = new List<Comment>();
    }

    // Method Return the number of comments
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // Method add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}
