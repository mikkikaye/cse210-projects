using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int userInput = 0;

        List <string> menu = new List<string>
            { 
                "Menu List",
                "1. Write a Journal Entry",
                "2. View Journal",
                "3. Load a Journal from a saved file",
                "4. Save your Journal",
                "5. End Program",
                "Choose an option from the list above:"
            };

        while (userInput != 5)
        {
            foreach(string choice in menu)
            {
                Console.WriteLine(choice);
            }
            string input = Console.ReadLine();
            userInput = int.Parse(input);
            if (userInput == 1)
            {
                Console.WriteLine();
                journal.CreateJournalEntry();
            }
            if (userInput == 2)
            {
                Console.WriteLine();
                journal.DisplayJournal(); 
            }
            if (userInput ==3)
            {
                Console.WriteLine();
                string myJournal = "myJournal.txt";
                FileStream filestream = File.Open(myJournal, FileMode.Open);

            }
            if (userInput == 4)
            {
                
            }
        }
    }
}