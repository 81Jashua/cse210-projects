using System;
using System.Collections.Generic;

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
        int smallNumber = 99999;
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userFeedback != 0)
        {
            userFeedback = int.Parse(Console.ReadLine());
            if (userFeedback != 0) 
            {
                numberList.Add(userFeedback);
                Console.WriteLine($"Entered number: {userFeedback}");                
            }             
        }
        numberList.Sort();        
        
        Console.WriteLine($"The sum is: {numberList.Sum()}");
        Console.WriteLine($"The average is: {numberList.Average()}");
        Console.WriteLine($"The largest number is: {numberList.Max()}");
        foreach(int num in numberList)
        {
            if (num > 0 && num < smallNumber) 
            {
                smallNumber = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallNumber}");

        Console.Write("The sorted list is: ");
        foreach(int num in numberList)
            {
                Console.Write($"{num},");
            }
    }
}