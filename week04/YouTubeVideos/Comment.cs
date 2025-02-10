using System;
public class Comment
{
    // Private attributes for comment
    private string commenterName;
    private string text;

    // Constructor to initialize a comment
    public Comment(string commenterName, string text)
    {
        this.commenterName = commenterName;
        this.text = text;
    }

    // Getter and Setter for CommenterName
    public string GetCommenterName()
    {
        return commenterName;
    }

    public void SetCommenterName(string commenterName)
    {
        this.commenterName = commenterName;
    }

    // Getter and Setter for Text
    public string GetText()
    {
        return text;
    }

    public void SetText(string text)
    {
        this.text = text;
    }

    // Method for displaying the comment details
    public void DisplayComment()
    {
        Console.WriteLine($"Commenter: {GetCommenterName()}");
        Console.WriteLine($"Comment: {GetText()}\n");
    }
}
