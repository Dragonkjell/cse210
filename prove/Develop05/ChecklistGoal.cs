public class ChecklistGoal : Goal
{
    //variables
    public int CurrentCount { get; set; }
    public int TargetCount { get; set; }

    //constructors
    public ChecklistGoal()
    {

    }
    
    public ChecklistGoal(string name, string details, int points, int bonusPoints, int targetCount, bool completed) : base(name, details, points, bonusPoints,completed)
    {

    }

    //methods
    public override void RecordEvent(int points)
    {
        int count = 0;

        if (count < targetCount)
        {
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else
        {
            Completed = true;
        }
        count++;

        if (Completed)
        {
            Console.WriteLine($"Congratulations! You have earned a bonus of {bonusPoints} points!");
        }
    }
}