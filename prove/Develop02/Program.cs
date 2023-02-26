using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter an option: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter a filename: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;
                case 4:
                    Console.Write("Enter a filename: ");
                    filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                    break;
                case 5:
                    return;
            }
        }
    }
}


