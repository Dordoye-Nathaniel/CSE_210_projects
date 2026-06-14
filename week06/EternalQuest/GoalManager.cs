using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");

            choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoalDetails();
                    break;

                case "3":
                    SaveGoals();
                    break;

                case "4":
                    LoadGoals();
                    break;

                case "5":
                    RecordEvent();
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid menu option.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You do not have any goals.");
            return;
        }

        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {_goals[i].GetDetailsString()}"
            );
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Progress Goal");

        Console.Write("Which type would you like to create? ");
        string goalType = Console.ReadLine() ?? "";

        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine() ?? "";

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine() ?? "";

        Console.Write("How many points is each event worth? ");

        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points value.");
            return;
        }

        if (goalType == "1")
        {
            _goals.Add(
                new SimpleGoal(shortName, description, points)
            );
        }
        else if (goalType == "2")
        {
            _goals.Add(
                new EternalGoal(shortName, description, points)
            );
        }
        else if (goalType == "3")
        {
            Console.Write("How many times must it be completed? ");

            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                Console.WriteLine("Invalid target.");
                return;
            }

            Console.Write("What is the completion bonus? ");

            if (!int.TryParse(Console.ReadLine(), out int bonus))
            {
                Console.WriteLine("Invalid bonus.");
                return;
            }

            _goals.Add(
                new ChecklistGoal(
                    shortName,
                    description,
                    points,
                    target,
                    bonus
                )
            );
        }
        else if (goalType == "4")
        {
            Console.Write("How many progress steps are required? ");

            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                Console.WriteLine("Invalid target.");
                return;
            }

            Console.Write("What is the completion bonus? ");

            if (!int.TryParse(Console.ReadLine(), out int bonus))
            {
                Console.WriteLine("Invalid bonus.");
                return;
            }

            _goals.Add(
                new ProgressGoal(
                    shortName,
                    description,
                    points,
                    target,
                    bonus
                )
            );
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }

        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You do not have any goals.");
            return;
        }

        Console.WriteLine("The goals are:");
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        int index = choice - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("That goal does not exist.");
            return;
        }

        int pointsEarned = _goals[index].RecordEvent();

        if (pointsEarned == 0)
        {
            Console.WriteLine("That goal is already complete.");
            return;
        }

        _score += pointsEarned;

        Console.WriteLine(
            $"Congratulations! You earned {pointsEarned} points!"
        );

        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine() ?? "";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(
                    goal.GetStringRepresentation()
                );
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine() ?? "";

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("The file is empty.");
            return;
        }

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] goalParts = lines[i].Split(':');

            string goalType = goalParts[0];
            string[] details = goalParts[1].Split(',');

            string shortName = details[0];
            string description = details[1];
            int points = int.Parse(details[2]);

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(details[3]);

                _goals.Add(
                    new SimpleGoal(
                        shortName,
                        description,
                        points,
                        isComplete
                    )
                );
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(
                    new EternalGoal(shortName, description, points)
                );
            }
            else if (goalType == "ChecklistGoal")
            {
                int bonus = int.Parse(details[3]);
                int target = int.Parse(details[4]);
                int amountCompleted = int.Parse(details[5]);

                _goals.Add(
                    new ChecklistGoal(
                        shortName,
                        description,
                        points,
                        target,
                        bonus,
                        amountCompleted
                    )
                );
            }
            else if (goalType == "ProgressGoal")
            {
                int target = int.Parse(details[3]);
                int bonus = int.Parse(details[4]);
                int amountCompleted = int.Parse(details[5]);

                _goals.Add(
                    new ProgressGoal(
                        shortName,
                        description,
                        points,
                        target,
                        bonus,
                        amountCompleted
                    )
                );
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}