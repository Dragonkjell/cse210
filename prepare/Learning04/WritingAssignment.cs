public class WritingAssignment : Assignment
{
    // member variables
    private string _title;

    // constructors
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // methods
    public string GetWritingInfo()
    {
        return $"Title: {_title}";
    }
}