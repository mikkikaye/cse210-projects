using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness program!");

        int userInput = 0;

        List <string> menu = new List<string>
            { 
                "Menu List",
                "1. Pre-Meditation Exercise Activity",
                "2. Reflection Activity",
                "3. Breathing Activity",
                "4. Listing Activity",
                "5. Quit",
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
                    ExerciseActivity exerciseActivity = new ExerciseActivity();
                    exerciseActivity.RunActivity();

                }  
            if (userInput == 2)
                {
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.RunActivity();

                }
                if (userInput == 3)
                {
                    BreatheActivity breatheActivity = new BreatheActivity();
                    breatheActivity.RunActivity();
                }
                if (userInput ==4)
                {
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                }
        }
    }
}