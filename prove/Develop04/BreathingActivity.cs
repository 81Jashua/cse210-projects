using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();                    
        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();
        Console.WriteLine($"Get ready...");
        Pause();
        Breaths();
        //ShowCountDown(GetDuration());
    }

    public void Breaths()
    {
        int seconds = GetDuration();
        bool breathIn = true;
        
        while (seconds >= 3)
        {

            int setCount;
            if (seconds > 0 && seconds < 6)
                    {
                        setCount = seconds;
                    }
            else 
            {
                setCount = 3;
            } 
            switch (breathIn)
            {
                case true:
                {
                    Console.Write($"Breath in... ");
                    ShowCountDown(setCount);
                    breathIn = false;
                    
                    break;
                }
                case false:
                {
                    Console.Write("Breath out... ");
                    ShowCountDown(setCount);
                    breathIn = true;

                    break;
                }
            }
            seconds -= 3;
        }        
    }
}