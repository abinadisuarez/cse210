using System;
using System.Threading;

// Exceeds requirements: Added an ActivityLog class that records every
// completed activity during the session. The menu shows how many have
// been completed, and quitting prints a summary with each activity's
// name and duration plus the total time.

class Program
{
    static void Main(string[] args)
    {
        ActivityLog log = new ActivityLog();
        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine($"\nActivities completed this session: {log.GetCount()}");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                log.Record(breathing);
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                log.Record(reflecting);
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                log.Record(listing);
            }
            else if (choice == "4")
            {
                quit = true;
            }
        }

        log.DisplaySummary();
        Thread.Sleep(5000);
    }
}