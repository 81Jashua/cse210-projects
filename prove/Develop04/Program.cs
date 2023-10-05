using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int selection = 1;
        while(selection != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Write\n  2. Display\n  3. Load\n  4. Quit");
            Console.Write("Select a choice from the menu: ");
            selection = Int32.Parse(Console.ReadLine());

            switch(selection)
            {
                case 1:
                {
                    //Start breathing activity
                    Console.Clear();
                    string name = "Breathing Activity";
                    string description = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.";
                    BreathingActivity breathingActivity = new BreathingActivity(name, description);
                    breathingActivity.Run();
                                                   
                    break;
                }
                case 2:
                {
                    //Start reflecting activity
                    Console.Clear();
                    string name = "Reflecting Activity";
                    string description = "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
                    ReflectingActivity reflectingActivity = new ReflectingActivity(name,description);
                    reflectingActivity.Run();

                    break;
                }
                case 3:
                {
                    //start listening activity
                    Console.WriteLine("You chose the listening activity");
                    break;
                }                    
            }
        }        
    }
}