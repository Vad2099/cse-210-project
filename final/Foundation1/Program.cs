using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.Comments.Add(new Comment("User1", "Nice video!"));
        video1.Comments.Add(new Comment("User2", "Great content!"));
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.Comments.Add(new Comment("User3", "Interesting topic!"));
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 200);
        video3.Comments.Add(new Comment("User1", "Nice video!"));
        video3.Comments.Add(new Comment("User2", "Great content!"));
        video3.Comments.Add(new Comment("User3", "Interesting topic!"));
        videos.Add(video3);

        foreach (var video in videos) {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLenght() + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments) {
                Console.WriteLine("- " + comment.GetPersonName() + ": " + comment.GetComment());
            }
            Console.WriteLine();
        }
    }
}
