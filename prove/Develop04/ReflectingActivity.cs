using System.IO.Compression;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    // member variables


    // constructors
    public ReflectingActivity()
    {
    }

    public ReflectingActivity(int duration) : base(duration)
    {
    }

    // methods
    // change to return a string
    public string GetPrompt() // chooses a random prompt
    {
        List<string> prompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

        Random random = new Random();

        int i = random.Next(prompts.Count);
        string promptAtIndex = prompts[i];

        return promptAtIndex;
    }

    public void PromptQuestion(int duration) // chooses a random question about the prompt
    {
        Random random = new Random();

        List<string> prompts = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

        for (int i = 0; i < duration; i++)
        {
            int index = random.Next(prompts.Count);
            
            Console.WriteLine($"{prompts[index]}");

            prompts.RemoveAt(index);
            ShowSpinner();
            duration = duration - 5;
        }
    }
}