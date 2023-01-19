using System;
using System.Linq;

public class Resume
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        //using linq method to iterate over the list
        _jobs.ForEach(job => job.Display());
    }
}
