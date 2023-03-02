using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            // create menu options
            Menu breathing = new Menu("Breathing exercise", new BreathingActivity());
            Menu reflection = new Menu("Reflection exercise", new ReflectionActivity());
            Menu listing = new Menu("Listing exercise", new ListingActivity());

            // create menu
            Menu menu = new Menu(new Menu[] { breathing, reflection, listing });

            // run menu
            Menu.Run();
    //     }
    // }





