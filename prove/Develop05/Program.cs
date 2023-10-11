using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        int selection = 1;
        while(selection != 6)
        {
            //Console.Clear();
            goalManager.DisplayScore();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            selection = Int32.Parse(Console.ReadLine());

            switch(selection)
            {
                case 1:
                {
                    //Create New Goal
                    Console.Clear();
                    goalManager.CreateGoal();
                    // string name = "Breathing Activity";
                    // string description = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.";
                    // BreathingActivity breathingActivity = new BreathingActivity(name, description);
                    // breathingActivity.Run();
                                                   
                    break;
                }
                case 2:
                {
                    //List Goals
                    Console.Clear();
                    goalManager.ListGoalDetails();
                    break;
                }
                case 3:
                {
                    //Save Goals
                    Console.Clear();
                    Console.WriteLine("What is the name of the file?");
                    string fileName = Console.ReadLine();
                    goalManager.SaveGoals(fileName);
                    break;
                }
                case 4:
                {
                    //Load Goals
                    Console.Clear();
                    Console.WriteLine("Load Goals");
                    break;
                }
                case 5:
                {
                    //Record Event
                    Console.Clear();
                    Console.WriteLine("Record Event");
                    break;
                }                                     
            }
        }        
    }
}