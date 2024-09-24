using System;
using System.Collections.Generic;
public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public Resume(string name)
    {
        _name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (var job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
