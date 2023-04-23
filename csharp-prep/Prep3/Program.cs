using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the Magic Number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);
        // Console.WriteLine("What is your guess? ");
        // string userGuess = Console.ReadLine();
        // int magicGuess = int.Parse(userGuess);

        int tryGuess = -1;

        while (tryGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            tryGuess = int.Parse(Console.ReadLine());

            if (magicNumber > tryGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < tryGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}