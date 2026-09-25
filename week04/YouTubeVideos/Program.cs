using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ---------- Video 1 ----------
        Video video1 = new Video("C# Basics for Beginners", "CodeWithMosh", 720);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "Can you make one on LINQ?"));

        // ---------- Video 2 ----------
        Video video2 = new Video("Top 10 Programming Languages 2024", "TechGuru", 540);
        video2.AddComment(new Comment("Diana", "Python should be #1!"));
        video2.AddComment(new Comment("Ethan", "Rust is underrated."));
        video2.AddComment(new Comment("Fiona", "Java is still going strong."));
        video2.AddComment(new Comment("George", "Where is Kotlin?"));

        // ---------- Video 3 ----------
        Video video3 = new Video("How to Build a PC", "LinusTechTips", 1200);
        video3.AddComment(new Comment("Hannah", "This saved me so much money."));
        video3.AddComment(new Comment("Ian", "What about AMD vs Intel?"));
        video3.AddComment(new Comment("Julia", "Bookmarked!"));

        // ---------- Video 4 ----------
        Video video4 = new Video("Cooking the Perfect Steak", "ChefGordon", 480);
        video4.AddComment(new Comment("Kevin", "Mine always turns out dry."));
        video4.AddComment(new Comment("Laura", "Butter at the end is key!"));
        video4.AddComment(new Comment("Mike", "Tried it, best steak ever."));

        // ---------- Put all videos in a list ----------
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // ---------- Display each video and its comments ----------
        foreach (Video video in videos)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}