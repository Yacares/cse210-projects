public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            goalManager.DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                goalManager.CreateGoal();
            }
            else if (choice == "2")
            {
                goalManager.ListGoalNames();
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                goalManager.SaveGoals();
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                goalManager.LoadGoals();
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                goalManager.RecordEvent();
            }

            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Goal goal = _goals[i];
                string completionStatus = goal.IsComplete() ? "[X]" : "[ ]";
                string additionalInfo = "";

                if (goal is ChecklistGoal checklistGoal)
                {
                    additionalInfo = $"- Completed {checklistGoal.GetAmountCompleted()}/{checklistGoal.GetTarget()} times";
                }

                Console.WriteLine($"{i + 1}. {completionStatus} {goal.GetShortName()} - {goal.GetDescription()} ({goal.GetPoints()}points) {additionalInfo}");
            }
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
            Console.WriteLine(new string('-', 30));
        }

        Console.WriteLine("\nPress Enter to return to the menu.");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string input = Console.ReadLine();

        Console.Write("Enter the name of your goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the amount of points associated with this goal: ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.Write("Please enter a valid number for points: ");
        }


        Goal goal = null;

        if (input == "1")
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (input == "2")
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (input == "3")
        {
            Console.Write("Enter the number of times to complete the goal: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter the bonus points upon completion: ");
            int bonus = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(name, description, points, target, bonus);
        }

        if (goal != null)
        {
            _goals.Add(goal);
            Console.WriteLine("Goal created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal type selected.");
        }

        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal would you like to record an event for?");
        ListGoalNames();

        if (!int.TryParse(Console.ReadLine(), out int goalIndex))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.ReadLine();
            return;
        }

        goalIndex -= 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            int pointsEarned = 0;

            if (goal is SimpleGoal simpleGoal && !simpleGoal.IsComplete())
            {
                simpleGoal.RecordEvent();
                pointsEarned = simpleGoal.GetPoints();
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                int previousCount = checklistGoal.GetAmountCompleted();
                bool wasComplete = checklistGoal.IsComplete();

                checklistGoal.RecordEvent();


                if (!wasComplete || checklistGoal.GetAmountCompleted() > previousCount)
                {
                    pointsEarned = checklistGoal.GetPoints();

                    if (checklistGoal.IsComplete())
                    {
                        pointsEarned += checklistGoal.GetBonus();
                    }
                }
            }
            else if (goal is EternalGoal eternalGoal)
            {
                eternalGoal.RecordEvent();
                pointsEarned = eternalGoal.GetPoints();
            }

            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points! Total score is now {_score}.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }


    public void SaveGoals()
    {
        string filePath = "goals.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals have been successfully saved to 'goals.txt'.");

    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');

            Goal goal = null;

            switch (parts[0])
            {
                case "SimpleGoal":
                    goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4])) goal.RecordEvent();
                    break;

                case "EternalGoal":
                    goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    break;

                case "ChecklistGoal":
                    goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]));
                    for (int j = 0; j < int.Parse(parts[5]); j++)
                    {
                        goal.RecordEvent();
                    }
                    break;
            }

            if (goal != null)
            {
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");

    }
}