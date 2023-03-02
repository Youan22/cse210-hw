public class BreathingActivity : Activity
{
    public override void start()
    {
        Console.WriteLine("Starting breathing exercise...");
        Console.WriteLine("Breathe in...");
        display_countdown(5);
        Console.WriteLine("Breathe out...");
        display_countdown(5);
        Console.WriteLine("Breathe in...");
        display_countdown(5);
        Console.WriteLine("Breathe out...");
        display_countdown(5);
        Console.WriteLine("Breathe in...");
        display_countdown(5);
        Console.WriteLine("Breathe out...");
        display_countdown(5);
    }
    
    public void display_countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write("{0}... ", i);
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}