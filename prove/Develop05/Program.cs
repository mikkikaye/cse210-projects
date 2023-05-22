using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Goal-Setting Game!");

        int userInput = 0;
        Person person = new Person();
        List <string> menu = new List<string>
            { 
                "Menu List",
                "1. Add New Goal",
                "2. See Current Goals",
                "3. See All Goals",
                "4. Check Score",
                "5. Mark Goal Complete",
                "6. Save Goals as CSV file",
                "7. Load Goals from CSV file",
                "8. Quit",
                "Choose an option from the list above:"
            };
        while (userInput != 8)
        {
            foreach(string choice in menu)
            {
                Console.WriteLine(choice);
            }

            string input = Console.ReadLine();
            userInput = int.Parse(input); 
            if (userInput == 1)
            {
                person.AddGoal();
            }  
            if (userInput == 2)
            {
                person.DisplayAllGoals(false);
                Console.ReadLine();
            }
            if (userInput == 3)
            {
                person.DisplayAllGoals();
                Console.ReadLine();
            }
            if (userInput == 4)
            {
                person.DisplayScore();
                Console.ReadLine();
            }
            if (userInput == 5)
            {
                person.EnterEvent();
                Console.ReadLine();
            }
            if (userInput == 6)
            {
                person.SaveAsCSV();
                Console.ReadLine();
            }
            if (userInput == 7)
            {
                person.LoadFromCSV();
            }  

        }
    }
}