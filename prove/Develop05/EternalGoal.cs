public class EternalGoal : Goal
{
    //variables


    //constructors
    public EternalGoal()
    {

    }
    
    public EternalGoal(string name, string details, int points, bool completed) : base(name, details, points, completed)
    {

    }

    //methods
    public override void RecordEvent(int Points)
    {
        Completed = false;
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
    }
}