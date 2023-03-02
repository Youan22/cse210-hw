using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are some things that make you happy?",
        "What are some things that you are grateful for?",
        "What are some things that you want to accomplish?",
        "What are some things that you are proud of?"
    };

    public void RunActivity()
    {
        Console.WriteLine("Welcome to the Listing Activity!");
        Console.WriteLine("Please respond to the following prompts:");

        foreach (string prompt in prompts)
        {
            Console.Write(prompt + " ");
            string response = Console.ReadLine();
            Console.WriteLine("You entered: " + response);
        }

        Console.WriteLine("Thank you for participating in the Listing Activity!");
    }
}
