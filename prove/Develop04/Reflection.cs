public class ReflectionActivity : Activity
{
    public List<string> prompts;
    public List<string> questions;
    
    public ReflectionActivity()
    {
        prompts = new List<string>{"What are you grateful for today?", "What did you learn today?", "What can you do better tomorrow?"};
        questions = new List<string>{"Why did you choose that answer?", "How can you apply what you learned?", "What steps will you take to improve?"};
    }
    
    public override void start()
    {
        Console.WriteLine("Starting reflection exercise...");
        Console.WriteLine("Prompt: {0}", get_random_prompt());
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Question {0}: {1}", i+1, get_random_question());
            System.Threading.Thread.Sleep(2000);
        }
    }
    
    public string get_random_prompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }
    
    public string get_random_question()
    {
        Random rand = new Random();
        return questions[rand.Next(questions.Count)];
    }
}