using System.Threading;
public class BreathingActivity : Activity
{
    // member variables
    

    // constructors
    public BreathingActivity()
    {
    }
    public BreathingActivity(int duration) : base(duration)
    {
    }

    // methods
    // public void BreathTimer(int duration) //display breathe in/breathe out every 5 secs
    // {
    //     // this won't be the exact duration, but I want it to finish the cycle of in/out before quitting
    //     for (int i = 0; i < duration; i++)
    //         {
    //         Console.Clear();
    //         Console.Write("Breathe in...");
    //         ShowCountdown();
    //         Console.Clear();
    //         Console.Write("Breathe out...");
    //         ShowCountdown();
    //         Console.Clear();
    //         duration = duration - 10;
    //         }
    // }

        public void BreathTimer(int duration) //display breathe in/breathe out every 5 secs
    {
        // this won't be the exact duration, but I want it to finish the cycle of in/out before quitting

        string arrow = ">";
        int maxDashes = 6;

        for (int i = 0; i < duration; i++)
        {
            for (int j = 0; j < maxDashes; j++)
            {
                Console.Clear();
                Console.WriteLine($"{arrow} Breath In");
                arrow = arrow.Insert(0, "-");
                Thread.Sleep(1000);
            }

            for (int k = 5; k > 0; k--)
            {
                Console.Clear();
                Console.WriteLine($"{arrow} Breath Out");
                arrow = arrow.Remove(0, 1);
                Thread.Sleep(1000);
            }
            
            duration = duration - 10;
        }
    }
}