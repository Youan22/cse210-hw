using System;

public class Job
{
    private string _company;
    private string _jobTitle;
    private int _startYear;
    private int _endYear;

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    public string Company { get { return _company; } set { _company = value; } }
    public string JobTitle { get { return _jobTitle; } set { _jobTitle = value; } }
    public int StartYear { get { return _startYear; } set { _startYear = value; } }
    public int EndYear { get { return _endYear; } set { _endYear = value; } }

    public void DisplayJobDetails()
    {
        Console.WriteLine("{0} ({1}) {2}-{3}", _jobTitle, _company, _startYear, _endYear);
    }
}
