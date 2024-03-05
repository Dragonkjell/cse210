public class Activity
{
    // member variables
    private string _startMessage;
    private string _endingMessage;
    // private int _duration;

    // constructors
    public Activity()
    {
    }
    public Activity(int duration)
    {
    }

    // methods
    public void ShowSpinner() // displays a spinner
    {
        List<string> animation = new List<string>() {"|", "/", "-", "\\", "|", "/", "-", "\\", "|"};
        foreach (string character in animation)
        {
            Console.Write(character);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void ShowCountdown() // displays a countdown
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void SetStartingMessage(string startMessage) // sets the starting message
    {
        _startMessage = startMessage;

    }
    public string GetStartingMessage() // displays the starting message
    {
        return _startMessage;
    }

    public void SetEndingMessage(string endingMessage) // sets the ending message
    {
        _endingMessage = endingMessage;
    }

    public string GetEndingMessage() // displays the ending message
    {
        return _endingMessage;
    }
}