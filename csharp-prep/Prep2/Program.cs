/*
Write a program that determines the letter grade for a course according to the following scale:

A >= 90
B >= 80
C >= 70
D >= 60
F < 60

Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the 
appropriate letter grade. (At this point, you'll have a separate print statement for each grade letter in the 
appropriate block.)

Assume that you must have at least a 70 to pass the class. After determining the letter grade and 
printing it out. Add a separate if statement to determine if the user passed the course, and if so display a 
message to congratulate them. If not, display a different message to encourage them for next time.

Change your code from the first part, so that instead of printing the letter grade in the body of each if, 
elif, or else block, instead create a new variable called letter and then in each block, set this variable to 
the appropriate value. Finally, after the whole series of if-elif-else statements, have a single print 
statement that prints the letter grade once.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! I am here to help you understand your current grades!");
        Console.Write("Please enter your grade: ");
        string grade = Console.ReadLine();
        float grades = float.Parse(grade);

        Console.WriteLine("Please give me a moment to think.");
        Console.WriteLine("Thinking....Thinking....Thinking...");
        Console.WriteLine("Done!");
        Console.WriteLine(" ");

        string letter_grade = (" ");
        string comment = (" ");
        if (grades >= 90)
        {
            letter_grade = ("A");
            comment = ("Great job! An A is as high as you can get!");
        }
        else if (grades >= 80)
        {
            letter_grade = ("B");
            comment = ("You are doing great.");
        }
        else if (grades >= 70)
        {
            letter_grade = ("C");
            comment = ("Good news! A C is still passing, but you might want go to the tutoring center for help.");
        }
        else if (grades >= 60)
        {
            letter_grade = ("D");
            comment = ("Hey buddy, things are looking kinda rough. But maybe some time in the tutoring lab can help! So keep trying.");
        }
        else
        {
            letter_grade = ("F");
            comment = ("I don't think only going to the tutoring lab will help this time. Have you talked to your teacher yet? They want to help. Just hold on.");

        }

        Console.WriteLine("Your grade is " + letter_grade);
        Console.WriteLine(comment);
    
    }
}