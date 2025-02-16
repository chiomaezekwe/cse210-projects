using System;
public class Assignment
{
    // Private member variables.
    private string _studentName;
    private string _topic;

    // Constructor to initialize the base class.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to return summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter method to access the student name from derived classes
    public string GetStudentName()
    {
        return _studentName;
    }
}
