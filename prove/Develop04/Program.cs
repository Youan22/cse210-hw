using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        for (int i = 5; i > 0; i--)
        {

        Console.WriteLine(i);
        Thread.Sleep(1000);
        }
        // Console.WriteLine(4);
        // Thread.Sleep(1000);
        // Console.WriteLine(3);
        // Thread.Sleep(1000);
        // Console.WriteLine(2);
        // Thread.Sleep(1000);
        // Console.WriteLine(1);
        // Thread.Sleep(1000);
        Console.WriteLine("Done");
    }
}