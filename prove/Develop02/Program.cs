using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            
        }

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select an operation:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        string choice = Console.ReadLine();
        DateTime currentDate = DateTime.Today;
        
        while (!(choice == "5")) {

            if (choice == "1") {
                Entry newEntry = new Entry();
                newEntry._date = currentDate.ToString();
                newEntry._promptText = "None";
                newEntry._entryText = "None";

                newEntry._promptText = PromptGenerator.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                newEntry._entryText = Console.ReadLine();
                Journal.AddEntry(newEntry);
            } 
            else if (choice == "2") {
                Journal.DisplayAll();
            }
            else if (choice == "3") {
                Console.WriteLine("Name the file you want to load.");
                string fileLoad = @$"{Console.ReadLine()}";
                Journal.LoadFromFile(fileLoad);
            }
            else if (choice == "4") {
                Console.WriteLine("What is the file name?");
                string file = @$"{Console.ReadLine()}";
                Journal.SaveToFile(file);
            }

            Console.WriteLine("Please select another operation.");
            choice = Console.ReadLine();
        }
    }
}