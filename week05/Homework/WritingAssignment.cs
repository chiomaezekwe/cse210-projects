using System;
public class WritingAssignment : Assignment
{
    // Private member variable
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)  // Calling the base class constructor
    {
        _title = title;
    }

    // Method to return the title and student name using the GetStudentName() from the base class
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
