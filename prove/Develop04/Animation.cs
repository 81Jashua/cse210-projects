public class Animation
{
    public static void ShowSpinner(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character            
            
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write("\b \b");            
            
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write("\b \b");
            
            Console.Write("|"); // Replace it with the - character
            Thread.Sleep(250);
            Console.Write("\b \b");
            
        
            seconds -= 1;
        }
        Console.Write("\n");        
    }

    public static void ShowCountDown(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character            
             
            seconds -= 1;
        }
        Console.Write("\n");
    }

    public static void Pause(int seconds)
    {
        Console.WriteLine("Going to sleep for a second...");
        Thread.Sleep(1000);
        Console.WriteLine("I'm back!!");
    }
}