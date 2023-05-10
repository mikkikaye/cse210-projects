using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Fred Weasley", "Numbers & Words");
        string print = assignment.GetSummary();
        Console.WriteLine(print);

        MathAssignment mathAssignment = new MathAssignment( "7.3", "8-19", "Fred Weasley", "Math");
        string printSecond = mathAssignment.GetHomeworkList();
        Console.WriteLine(printSecond);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of WWII");
        string printThird = writingAssignment.GetSummary();
        Console.WriteLine(printThird);
        string printFourth = writingAssignment.GetWritingInformation();
        Console.WriteLine(printFourth);
    }
}