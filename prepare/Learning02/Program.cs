using System;

class Program
{
    static void Main(string[] args)
    {
        Job firstJob = new Job();
        firstJob._company = "Microsoft";
        firstJob._jobTitle = "Developer";
        firstJob._startYear = 2013;
        firstJob._endYear = 2021;

        Job secondJob = new Job();
        secondJob._company = "Apple";
        secondJob._jobTitle = "Business Analyst";
        secondJob._startYear = 2019;
        secondJob._endYear = 2023;
        //Console.WriteLine($"{newJob._company} {newJob._jobTitle}");
        //firstJob.Display();

        Resume firstResume = new Resume();
        firstResume._name = "Josh Snyder";
        firstResume._jobs.Add(firstJob);
        firstResume._jobs.Add(secondJob);

        firstResume.Display();
    }
}