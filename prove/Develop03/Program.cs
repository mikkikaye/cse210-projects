using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        string input = "";
        if (scripture.HasWordsLeft() == true)
        {
            do {
                scripture.DisplayScripture();
                Console.WriteLine("\nTap enter to keep removing words or type 'quit' to end the program.");
                input = Console.ReadLine();
                scripture.RemoveWord();
            } while (input != "quit");
        }
    }
}