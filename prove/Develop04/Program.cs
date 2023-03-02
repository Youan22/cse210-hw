// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop04 World!");

//         // for (int i = 5; i > 0; i--)
//         // {

//         // Console.WriteLine(i);
//         // Thread.Sleep(1000);
//         // }
//         // Console.WriteLine(4);
//         // Thread.Sleep(1000);
//         // Console.WriteLine(3);
//         // Thread.Sleep(1000);
//         // Console.WriteLine(2);
//         // Thread.Sleep(1000);
//         // Console.WriteLine(1);
//         // Thread.Sleep(1000);
//         List<string> animationStrings = new List<string>();
//         animationStrings.Add("|");
//         animationStrings.Add("/");
//         animationStrings.Add("-");
//         animationStrings.Add("\\");
//         animationStrings.Add("|");
//         animationStrings.Add("/");
//         animationStrings.Add("-");
//         animationStrings.Add("\\");

//         // foreach (string s in animationStrings)
//         // {

//         // Console.Write(s);
//         // Thread.Sleep(1000);
//         // Console.Write("\b \b");
//         // }

//         DateTime startTime = DateTime.Now;
//         DateTime endTime = startTime.AddSeconds(15);

//         int i = 0;

//         while (DateTime.Now < endTime)
//         {
//             string s = animationStrings[i];
//             Console.Write(s);
//             Thread.Sleep(1000);
//             Console.Write("\b \b");

//             i++;

//             if (i >= animationStrings.Count)
//             {
//                 i = 0;
//             }
            
//             // Console.Write(".");
//             // Thread.Sleep(1000);
//         }

//         Console.WriteLine("Done");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Menu.Run();
//     }
// }

using System;
using System.Collections.Generic;
//using System.Windows.Forms;


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





