using System;
// using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project..");
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2010;
        job1._endYear = 2011;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2014;
        job2._endYear = 2017;

        // List<Job> job = new List<Job>();
        // job.Add(job1);
        // job.Add(job2);

        // foreach (Job j in job)
        // {
        //     // Console.WriteLine(j._company);
        //     j.DisplayJobDetails();
        // }

        Resume myResume = new Resume();
        myResume._name = "Ovidio Luces";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobs();
    }
}