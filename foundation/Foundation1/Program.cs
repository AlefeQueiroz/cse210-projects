using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create 3-4 videos
        Video video1 = new Video("C# Tutorial for Beginners", "Tech Academy", 600);
        Video video2 = new Video("Introduction to OOP", "Code Simplified", 900);
        Video video3 = new Video("Learn Data Structures", "Programming Hub", 1200);

        // Add comments to each video
        video1.AddComment(new Comment("Alice", "This is really helpful!"));
        video1.AddComment(new Comment("Bob", "Great tutorial!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot from this!"));

        video2.AddComment(new Comment("Dave", "Clear explanation!"));
        video2.AddComment(new Comment("Eve", "Loved this video."));
        video2.AddComment(new Comment("Frank", "More content on this please!"));

        video3.AddComment(new Comment("Grace", "This is excellent!"));
        video3.AddComment(new Comment("Heidi", "Thanks for the detailed breakdown."));
        video3.AddComment(new Comment("Ivy", "Very informative!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the videos and display information for each
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
