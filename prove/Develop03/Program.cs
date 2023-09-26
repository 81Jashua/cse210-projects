using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("verse",2,12);

        Console.WriteLine(reference.GetDisplayText());
    }
}