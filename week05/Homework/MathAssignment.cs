using System;
public class MathAssignment : Assignment
{
    // Private member variables.
    private string _textbookSection;
    private string _problems;

    // Constructor to initialize the MathAssignment class.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)  // Call base class constructor
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to return the list of homework problems in the Maths assignment
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
