using System;

public class Person
{
    private int _score;
    private List<Goal> _goals;
    public Person()
    {
        _score = 0;
        _goals = new List<Goal>();
    }
    private void AddToScore(int _points)
    {
        _score += _points;
    }
    public void DisplayScore()
    {
        Console.WriteLine($"{_score}");
    }
    public void AddGoal()
    {
        Console.WriteLine("Choose your goal type (1. Simple, 2. Checklist, or 3. Perpetual): ");
        string type = Console.ReadLine();
        int goalType = int.Parse(type); 
        Console.WriteLine("Enter a name for your goal: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter a goal description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter a positive point value for completing your goal: ");
        string userInput = Console.ReadLine();
        int points = int.Parse(userInput);
        switch(goalType)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                break;
            case 2: 

                Console.WriteLine("How many times do you want to do this goal?");
                string x = Console.ReadLine();
                int goalCount = int.Parse(x);
                Console.WriteLine($"How many bonus points do you want to earn at the end of completing this goal {goalCount} times?");
                string y = Console.ReadLine();
                int bonusPoints = int.Parse(y);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, goalCount, bonusPoints);
                _goals.Add(checklistGoal);
                break;
            case 3:
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
        }
    }
    public void DisplayAllGoals()
    {
        foreach (Goal goal in _goals)
        {
            goal.DisplayGoal();
        }
    }
        public void DisplayAllGoals(bool complete)
    {
        foreach (Goal goal in _goals)
        {
            if (goal.GetComplete() == complete)
            {
                goal.DisplayGoal();
            }
        }
    }
    public Goal ChooseGoal(bool complete)
    {
        List<Goal> incomplete = new List<Goal>();
        foreach (Goal goal in _goals)
        {
            if (goal.GetComplete() == complete)
            {
                incomplete.Add(goal);
            }
        }
        int index = 0;
        Console.WriteLine("Choose from the list of incomplete goals below:");
        foreach (Goal goal in incomplete)
            {
                Console.WriteLine($"{index}. {goal}");
                index++;
            }
        string userInput = Console.ReadLine();
        int goalChoice = int.Parse(userInput);
        return incomplete[goalChoice];
    }
    public bool SaveAsCSV()
    {
        using (StreamWriter streamWriter = new StreamWriter("myGoals.txt"))
        {
            streamWriter.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                string listGoals = goal.GetGoalAsCSV();
                streamWriter.WriteLine(listGoals);
            }
        }
        return true;
    }
    public void EnterEvent()
    {
        Goal goal = ChooseGoal(false);
        AddToScore(goal.Complete());
        Console.WriteLine("Good job on completing your goal!");
    }
    public void LoadFromCSV()
    {
        List<Goal> goal = new List<Goal>();
        using (StreamReader reader = new StreamReader("myGoals.txt"))
        {
            string line = "a";
            _score = int.Parse(reader.ReadLine());
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                string[] fields = line.Split("|");
                string type = fields[0];
                string name = fields[1];
                string description = fields[2];
                int points = int.Parse(fields[3]);
                bool complete = bool.Parse(fields[4]);
                int goalCount = int.Parse(fields[5]);
                int bonusPoints = int.Parse(fields[6]);
                switch(type)
                {
                    case "Simple":
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        _goals.Add(simpleGoal);
                        if (complete)
                        {
                            simpleGoal.Complete();
                        }
                        break;
                    case "Checklist": 
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, goalCount, bonusPoints);
                        _goals.Add(checklistGoal);
                        if (complete)
                        {
                            checklistGoal.Complete();
                        }
                        break;
                    case "Perpetual":
                        EternalGoal eternalGoal = new EternalGoal(name, description, points);
                        _goals.Add(eternalGoal);
                        break;
                }
            }
        }
    }
}