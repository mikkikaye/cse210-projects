using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
            Console.WriteLine($"Your letter grade is an {letter}.");
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
            Console.WriteLine($"Your letter grade is a {letter}.");
        }
        else if (gradePercentage >=70)
        {
            letter = "C";
            Console.WriteLine($"Your letter grade is a {letter}.");
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
            Console.WriteLine($"Your letter is a {letter}.");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"Your letter grade is an {letter}.");
        }
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"You passed the class!");
        }
        if (gradePercentage < 70)
        {
            Console.WriteLine($"You did not pass the class. Try harder next time!");
        }
    }
}