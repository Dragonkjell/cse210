using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create a point value to be updated everytime you load a file
        int totalPoints = 0;

        //create a list of goals
        List<Goal> goalsList = new List<Goal>();
        Goal goal = new Goal();

        Console.WriteLine("Welcome to the Goal Tracker! Please choose an option:");
        while (Console.ReadLine() != "7")
        {
            // create a menu

            Console.WriteLine("[1] Create New Goal\n" +
                                "[2] List Goals\n" +
                                "[3] Save Goals\n" +
                                "[4] Load Goals\n" +
                                "[5] Record Event\n" +
                                "[6] Count Points\n" +
                                "[7] Quit");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1: //create new goal
                    Console.WriteLine("Which type of goal would you like to create?\n" +
                    "[1] Simple Goal\n" +
                    "[2] Eternal Goal\n" +
                    "[3] Checklist Goal");
                    
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1: //one time goal
                            Console.WriteLine("What is the name of your goal? ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Give some basic details of the goal: ");
                            string details = Console.ReadLine();

                            Console.WriteLine("How many points is this goal worth? ");
                            int points = int.Parse(Console.ReadLine());

                            Goal oneTimeGoal = new OneTimeGoal(name, details, points, false);
                            goalsList.Add(oneTimeGoal);

                            break;

                        case 2: //eternal goal
                            Console.WriteLine("What is the name of your goal? ");
                            name = Console.ReadLine();
                            
                            Console.WriteLine("Give some basic details of the goal: ");
                            details = Console.ReadLine();
                            
                            Console.WriteLine("How many points is this goal worth? ");
                            points = int.Parse(Console.ReadLine());
                            
                            Goal eternalGoal = new EternalGoal(name, details, points, false);
                            goalsList.Add(eternalGoal);

                            break;
                            
                        case 3: //checklist goal
                            Console.WriteLine("What is the name of your goal? ");
                            name = Console.ReadLine();
                            
                            Console.WriteLine("Give some basic details of the goal: ");
                            details = Console.ReadLine();
                            
                            Console.WriteLine("How many points is this goal worth each time you do it? ");
                            points = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine("How many times do you want to complete this goal? ");
                            int targetCount = int.Parse(Console.ReadLine());

                            Console.WriteLine("How many bonus points do you get when you meet the target? ");
                            int bonusPoints = int.Parse(Console.ReadLine());
                            
                            Goal checklistGoal = new ChecklistGoal(name, details, points, targetCount, false);
                            goalsList.Add(checklistGoal);

                            break;
                    }

                    break;

                case 2: //list goals
                    int index = 0;
                    foreach (Goal singleGoal in goalsList)
                    {
                        
                        if (singleGoal.Completed)
                        {
                            Console.WriteLine($"{index + 1} [X] {singleGoal.Name} - {singleGoal.Details} - {singleGoal.Points} points");
                        }
                        else
                        {
                            Console.WriteLine($"{index + 1} [ ] {singleGoal.Name} - {singleGoal.Details} - {singleGoal.Points} points");
                        }
                        index++;
                    }
                    break;

                case 3: //save goals
                    Console.WriteLine("Enter the file name to save to: ");
                    string saveFile = Console.ReadLine();

                    string json = JsonSerializer.Serialize(goalsList);
                    File.WriteAllText(saveFile, json);
                    break;

                case 4: //load goals
                    Console.WriteLine("Enter the file name to load from: ");
                    string loadFile = Console.ReadLine();

                    string jsonData = File.ReadAllText(loadFile);
                    goalsList = JsonSerializer.Deserialize<List<Goal>>(jsonData);

                    foreach (Goal singleGoal in goalsList)
                    {
                        if (singleGoal.Completed)
                        {
                            totalPoints += singleGoal.Points;
                        }
                    }

                    Console.WriteLine("Goals loaded successfully!");
                    break;

                case 5: //record event
                    Console.WriteLine("Which goal did you accomplish? ");
                    int goalsListIndex = int.Parse(Console.ReadLine()) - 1;

                    // goalsList[goalsListIndex].Completed = true;
                    totalPoints += goalsList[goalsListIndex].Points;

                    goalsList[goalsListIndex].RecordEvent(goalsList[goalsListIndex].Points);
                    break;

                case 6: // list points
                    Console.WriteLine($"You have earned a total of {totalPoints} points!");
                    break;

                case 7: //quit
                    return;

                default:

                    break;
            }
        }
    }
}