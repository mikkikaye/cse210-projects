using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int listNumbers = -1;
        while (listNumbers != 0)
        { 
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            listNumbers = int.Parse(userInput);
            
            if (listNumbers != 0)
            {
                numbers.Add(listNumbers);
            }
        }


        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: " + numbers.Max());
    }
}       