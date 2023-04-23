using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string fullName = Name();
        int convNumber = Number();
        int squareNumber = Squared(convNumber);
        Sentence(fullName, squareNumber);
    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string Name()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int Number()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int favNumber = int.Parse(number);
        return favNumber;
    }

    static int Squared(int favNumber)
    {
        int squareNumber = favNumber * favNumber;
        return squareNumber;
    }

    static void Sentence(string fullName, int squareNumber)
    {
        Console.WriteLine($"{fullName}, the square of your number is {squareNumber}.");
    }
}