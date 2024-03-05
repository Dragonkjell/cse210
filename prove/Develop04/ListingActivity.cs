public class ListingActivity : Activity
{
    // member variables
    List<string> listedItems = new List<string>();


    // constructors
    public ListingActivity()
    {
    }

    public ListingActivity(int duration) : base(duration)
    {
    }

    // methods
    public string GetPrompt()
    {
        List<string> prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "What obstacles have you dealt with?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

        Random random = new Random();

        int index = random.Next(prompts.Count);
        string prompt = prompts[index];

        return prompt;
    }

    public void ListItems(int duration)
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        ShowSpinner();
        Console.WriteLine(GetPrompt());
        ShowSpinner();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            listedItems.Add(Console.ReadLine());
        }
    }

    public int ItemCount()
    {
        int ItemCount = listedItems.Count();

        return ItemCount;
    }
}