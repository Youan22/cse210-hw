using System;
public class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public string Date { get; }

    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }

    public Entry()
    {
        Console.WriteLine("Enter title: ");
        Title = Console.ReadLine();
        Console.WriteLine("Enter content: ");
        Content = Console.ReadLine();
        CreatedAt = DateTime.Now;
    }

public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}