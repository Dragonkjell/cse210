using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Groomer";
        job1._startYear = 2004;
        job1._endYear = 2014;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Monkey Developer";
        job2._startYear = 2001;
        job2._endYear = 2016;

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();
        Resume resume1 = new Resume();
        
        resume1._name = "Johnny Cash";

        resume1._job.Add(job1);
        resume1._job.Add(job2);

        resume1.DisplayResumeDetails();
    }
}