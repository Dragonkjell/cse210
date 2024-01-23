public class Resume
{
    public string _name;

    public List<Job> _job = new List<Job>();

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"{_name}");

        foreach (Job job in _job)
        {
            Console.WriteLine($"{job._company}, {job._jobTitle} {job._startYear} - {job._endYear}");
        }
    }
}