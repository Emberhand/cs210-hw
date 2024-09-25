using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;

        while (!(number == 0)) {
            Console.WriteLine("Give me a number. ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        int sum = 0;
        foreach (int i in numbers){
            sum = sum + i;
        }

        Console.WriteLine($"The sum of your numbers is: {sum}");
        
        float average = sum / numbers.Count ;
        Console.WriteLine($"The average of your numbers is: {average}");

        int highest = 0;
        for (int i = 0; i < numbers.Count; i++){
            if (i > highest){
                highest = i;
            }
        }
        Console.WriteLine($"The highest of your numbers is: {highest}");
    }
}