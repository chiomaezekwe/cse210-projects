using System;
public class Video
{
    // Private attributes for video
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    // Constructor to initialize video
    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();         // To initialize the comment list
    }

    // Getter and Setter for Title
    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }

    // Getter and Setter for Author
    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string author)
    {
        this.author = author;
    }

    // Getter and Setter for LengthInSeconds
    public int GetLengthInSeconds()
    {
        return lengthInSeconds;
    }

    public void SetLengthInSeconds(int lengthInSeconds)
    {
        this.lengthInSeconds = lengthInSeconds;
    }

    // Method to add a comment to video
    public void AddComment(string commenterName, string text)
    {
        comments.Add(new Comment(commenterName, text));
    }

    // Method to get the number of comments on a video
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Method for displaying video details with its comments
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Video Title: {GetTitle()}");
        Console.WriteLine($"Author: {GetAuthor()}");
        Console.WriteLine($"Length: {GetLengthInSeconds()} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}\n");

        foreach (var comment in comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine();            // Empty line after the video details
    }
}