public class OneTimeGoal : Goal
{
    //variables

    //constructors
    public OneTimeGoal()
    {

    }

    public OneTimeGoal(string name, string details, int points, bool completed) : base(name, details, points, completed)
    {

    }

    //methods

    public override void RecordEvent(int points)
    {
        Completed = true;
        Console.WriteLine($"Congratulations! You have earned {points} points!");
    }
}
