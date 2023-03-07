using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new scripture
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Display the scripture
        Console.WriteLine(scripture.GetRenderedText());
        Console.WriteLine("Press ENTER to continue or type 'quit' to exit.");

        // Hide words until the scripture is completely hidden
        while (!scripture.IsCompletelyHidden())
        {
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            scripture.HideWords();
            Console.WriteLine(scripture.GetRenderedText());
        }
    }
}

