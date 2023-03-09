public class Entry
{
    private string prompt;
    private string response;
    private string date;

    public Entry(string prompt, string response, string date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    public string Prompt
    {
        get { return prompt; }
        set { prompt = value; }
    }

    public string Response
    {
        get { return response; }
        set { response = value; }
    }

    public string Date
    {
        get { return date; }
        set { date = value; }
    }

    public override string ToString()
    {
        return $"Prompt: {prompt}\nResponse: {response}\nDate: {date}\n";
    }

    internal ReadOnlySpan<char> ToCSVString()
    {
        throw new NotImplementedException();
    }
}
