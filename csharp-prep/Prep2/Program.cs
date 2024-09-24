using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userGrade = Console.ReadLine();

        int grade = int.Parse(userGrade);
        string letterGrade = "";
        string status = "";

        if (grade >= 90)
        {
            letterGrade = "A";
            status = "passed";
        }
        else if (grade < 90 && grade >= 80)
        {
            letterGrade = "B";
            status = "passed";
        }
         else if (grade < 80 && grade >= 70)
        {
            letterGrade = "C";
            status = "passed";
        }
         else if (grade < 70 && grade >= 60)
        {
            letterGrade = "D";
            status = "failed";
        }
         else if (grade < 60)
        {
            letterGrade = "F";
            status = "failed";
        }

        Console.WriteLine($"{letterGrade}");
        Console.WriteLine("");

        if (status == "passed")
        {
            Console.WriteLine("You passed the class! Congratulations!");
        }
        else
        {
            Console.WriteLine("You failed the class. Keep trying!");
        }
    }
}