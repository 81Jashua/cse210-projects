using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        //Once you have a list, have your program do the following:
        //Compute the sum, or total, of the numbers in the list.
        //Compute the average of the numbers in the list.
        //Find the maximum, or largest, number in the list.

        int userFeedback = -1;
        List<int> numberList = new List<int>();

        while (userFeedback != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            userFeedback = int.Parse(Console.ReadLine());

            if (userFeedback != 0) 
            {
                numberList.Add(userFeedback);
            }             
        }
        
        foreach(int num in numberList)
        {
            Console.Write(num);
        }
        Console.WriteLine($"The total amount is: {numberList.Sum()}");
        Console.WriteLine($"The Average is: {numberList.Average()}");
        Console.WriteLine($"The largest number was: {numberList.Max()}");
    }
}