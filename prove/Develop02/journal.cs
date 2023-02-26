class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry()
    {
        int index = new Random().Next(prompts.Count);
        string prompt = prompts[index];
        Console.Write(prompt + ": ");
        string response = Console.ReadLine();
        entries.Add(new Entry(prompt, response, DateTime.Now.ToString()));
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry);
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split('|');
                entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }
    }
}
