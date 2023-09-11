using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percent = int.Parse(Console.ReadLine());

        string letterGrade = "";
        if (percent >= 90)
        {
            letterGrade = "A";
        }
        else if (percent >= 80)
        {
            letterGrade = "B";
        }
        else if (percent >= 70)
        {
            letterGrade = "B";
        }
        else if (percent >= 60)
        {
            letterGrade = "D";
        }
        else letterGrade = "F";
        

        string plusMinus = "";
        int lastDigit = percent % 10;
        
        if (lastDigit >= 7)
        {
            plusMinus = "+";
        }
        else if (lastDigit <= 3)
        {
            plusMinus = "-";
        }
        else plusMinus = "";
        Console.WriteLine($"Your grade is: {letterGrade}{plusMinus}");

        string message = "";
        if (percent >= 70){
            message = "You passed!";
        }
        else message = "Better luck next time!";
        Console.WriteLine(message);
    }
}

//A >= 90
//B >= 80
//C >= 70
//D >= 60
//F < 60