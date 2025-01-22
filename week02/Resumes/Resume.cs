using System;
using System.Collections.Generic;
public class Resume
{
    public string _name;
    public List<Job> _jobs;

    // Constructor to initialize the name and the list of jobs
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>(); 
    }

    // Method used to add a job to the job list
    public void AddJob(Job job)
    {
        _jobs.Add(job);  // Using Add() to add a job to the list
    }

    // Method used to display the resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();  // Display each job's details
        }
    }
}