using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many seconds: ");
        int sec = int.Parse(Console.ReadLine()); 
        Console.Write($"Hello Develop04 World!");
        //RunAnimation(10);
        Animation.RunAnimation(sec);
        Console.WriteLine("BOooooooooooOOOOooo");        
    }
}