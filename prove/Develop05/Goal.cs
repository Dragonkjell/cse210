using System.Dynamic;
using System.Text.Json;

public class Goal
{
    //variables
    public string Name { get; set; }
    public string Details { get; set; }
    public int Points { get; set; }
    public bool Completed { get; set; }

    //constructors
    public Goal()
    {
        
    }

    public Goal(string name, string details, int points, bool completed)
    {
        Name = name;
        Details = details;
        Points = points;
        Completed = completed;
    }

    //methods
    public virtual void RecordEvent(int points)
    {
    }

    //change to bool instead of void
    public void IsComplete()
    {
        Completed = true;
    }

    //use a list List<Goal>
    public void SaveToFile(List<Goal> goals, string saveFile)
    {
        List<string> entries = new List<string>();

        foreach (Goal goal in goals)
        {
            string entry = $"{goal.Name}|{goal.Details}|{goal.Points}|{goal.Completed}";
        
            entries.Add(entry);
        }

        File.WriteAllLines(saveFile, entries);

        Console.WriteLine("Goal saved successfully!");
    }

    //use a list List<Goal>
    public void LoadToFile()
    {
        try
        {

        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error loading {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error loading {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading {ex.Message}");
        }
    }
}