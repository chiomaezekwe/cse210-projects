using System;
public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Constructor to initialize the details of job
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Method used to display job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
