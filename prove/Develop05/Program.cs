using System;
using Microsoft.VisualBasic;

class Program
{

    // For my bit of creativity I created my own animation to use for my spinner.
    static void Main(string[] args) {
        BreathingActivity breathe = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
        string choice = "";

        while (!(choice == "4")) {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            choice = Console.ReadLine();
                if (choice == "1") {
                    breathe.Run();
                }
                else if (choice == "2") {
                    reflection.Run();
                }
                else {
                    listing.Run();
                }
        }
    }
}