using System;

class Program
{
    static void Main(string[] args)
    {
        Job newJob = new Job();
        newJob._company = "Microsoft";
        newJob._jobTitle = "Developer";
        newJob._startYear = 2013;
        newJob._endYear = 2021;
        //Console.WriteLine($"{newJob._company} {newJob._jobTitle}");
        newJob.Display();
    }
}