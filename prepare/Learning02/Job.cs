// Displays the job information in the format "Job Title (Company) StartYear-EndYear", 
// for example: "Software Engineer (Microsoft) 2019-2022".
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {

    }

    public void Display()
    {
        Console.WriteLine($"Job Title: {_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}