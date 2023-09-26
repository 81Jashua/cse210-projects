using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("verse",2,12);
        Word word = new("hello");

        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(word.GetDisplayText());
    }
}