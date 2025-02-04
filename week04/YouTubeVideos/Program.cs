using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Videos
        Video video1 = new Video("Learn C# in 30 minutes", "Juan Pérez", 180);
        video1.AddComment(new Comment("Ana López", "Excellent video, very clear"));
        video1.AddComment(new Comment("Carlos García", "Very helpful, thanks"));
        video1.AddComment(new Comment("Maria Fernández", "I will recommend it to my friends"));

        Video video2 = new Video("Introduction to Artificial Intelligence", "Laura venecia", 300);
        video2.AddComment(new Comment("Pedro Ortiz", "Interesting topic, I would like to know more"));
        video2.AddComment(new Comment("Marta Gonzalez", "Very complete and easy to understand"));

        Video video3 = new Video("Web Development with ASP.NET", "Luis Ramírez", 240);
        video3.AddComment(new Comment("José Fernández", "The best tutorial to start with"));
        video3.AddComment(new Comment("Lucía Torres", "I loved the online store example"));

        // List of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // The list videos and display their details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.Duration} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            // All comments from display
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  Comment by {comment.Author}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
