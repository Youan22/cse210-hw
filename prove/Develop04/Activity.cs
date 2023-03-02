public class Activity
{
    public int duration;
    
    public Activity()
    {
        duration = 60;
    }
    
    public virtual void start()
    {
        Console.WriteLine("Starting activity...");
        display_pause();
    }
    
    public void display_pause()
    {
        Console.Write("Pausing ");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine();
    }
    
    public virtual void end()
    {
        Console.WriteLine("Ending activity...");
        display_pause();
    }
}