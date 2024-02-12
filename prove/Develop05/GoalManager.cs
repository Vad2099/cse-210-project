using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Text;



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
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("\nMenu options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from menu: ");
            choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                CreateList();
                break;

                case 2:
                ListGoalDetails();
                break;

                case 3:
                SaveGoals();
                break;

                case 4:
                LoadGoals();
                break;

                case 5:
                RecordEvent();
                break;

                case 6:
                Console.Clear();
                Console.WriteLine("See you next time...");
                break;

                default:
                Console.WriteLine("Invalid choice. Please select again.");
                break;
            }
        }
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's Score: {_score}");
    }

    public void ListGoalNames()
    {
        int count = 1;
        Console.WriteLine("The goals are: ");
        foreach (Goal name in _goals)
        {
            Console.WriteLine($"{count}. {name.GetName()}");
            count++;
        }
    }

    public void ListGoalDetails()
    {
        int count = 1;

        Console.WriteLine("The goals are: ");

        foreach (Goal goal in _goals) 
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
        }

    }

    public void CreateList()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. ChecklistGoal");
        Console.Write("Which type of goal would you like to create? ");
        

        int goal = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the name of your goal: "); 
        string name = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points ");
        int points = Convert.ToInt32(Console.ReadLine());

        if (goal == 1)
        {
            SimpleGoal simple = new SimpleGoal(name, description, points);

            _goals.Add(simple);
        } 
        else if (goal == 2)
        {
            EternalGoal simple = new EternalGoal(name,description,points);
            _goals.Add(simple);
        }
        else if (goal == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus?");
            int target = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times?");
            int bonus = Convert.ToInt32(Console.ReadLine());

            CheckListGoal simple = new CheckListGoal(name, description, points, target, bonus);
            _goals.Add(simple);  
        }
        else
        {
            Console.WriteLine("Invalid option, please try again");
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which Goal did you accomplish?");
        int goalCompletedIndex = int.Parse(Console.ReadLine()) - 1; // Corregido: Ajustar el índice para acceder al objetivo.
        if (goalCompletedIndex >= 0 && goalCompletedIndex < _goals.Count)
        {
            _goals[goalCompletedIndex].RecordEvent();
            int earnedPoints = _goals[goalCompletedIndex].GetPoints();
            _score += earnedPoints;
            Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file?");
        string fileName= Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName)) 
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

   public void LoadGoals()
    {
        Console.Write("What is the filename for the goal life? ");
        string file = Console.ReadLine();
        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines.First());

        string[] text = lines.Skip(1).ToArray();
        

        foreach(string line in text)
        {
            string[] parts = line.Split(":");

            string goalType = parts[0];

            string details = parts[1];

            string[] part = details.Split(",");

            if (goalType == "SimpleGoal")
            {
                SimpleGoal simplePart = new SimpleGoal(part[0], part[1], int.Parse(part[2]));

                _goals.Add(simplePart);
                
            } else if (goalType == "EternalGoal")
            {
                EternalGoal eternalPart = new EternalGoal(part[0], part[1], int.Parse(part[2]));
                    
                _goals.Add(eternalPart);

            } else if (goalType == "ChecklistGoal")
            {
                CheckListGoal checklistPart = new CheckListGoal(part[0], part[1], int.Parse(part[2]), int.Parse(part[4]), int.Parse(part[3]));
                checklistPart.SetAmount(int.Parse(part[5]));

                _goals.Add(checklistPart);
            }

            } 
        }
}