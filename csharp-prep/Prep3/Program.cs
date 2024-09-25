using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        Console.WriteLine($"{number}");
        int guess = 0;
        
        while (!(number == guess))
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess == number) {
                Console.WriteLine("Yep, you guessed it!");
            }
            else if (guess > number) {
                Console.WriteLine("Lower.");
            }
            else {
                Console.WriteLine("Higher.");
            }
        }
    }

}