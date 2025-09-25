/*
Work through these core requirements step-by-step to 
complete the program. Please don't skip ahead and do 
the whole thing at once, because others on your team may 
benefit from building the program up slowly.

Compute the sum, or total, of the numbers in the list.

Compute the average of the numbers in the list.

Find the maximum, or largest, number in the list.
*/

using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Lising Numbers!");
        Console.WriteLine(" ");
        Console.WriteLine("Enter a number and press 'Enter' to add it to the list. Add 0 when you are done, 0 will not be added to the list.");
        Console.WriteLine(" ");

        bool end_list = false;

        List<float> funNumbers = new List<float>();

        while (end_list == false)
        {
            Console.Write("Enter Number: ");
            string number = Console.ReadLine();
            float number_added = float.Parse(number);
            if (number_added == 0)
            {
                end_list = true;
            }
            else
            {
                end_list = false;
                funNumbers.Add(number_added);
            }


        }
        float addition = 0;
        float max = 0;
        float average = 0;

        int index = funNumbers.Count;

        foreach (float number_in in funNumbers)
        {
            addition = addition + number_in;
            Console.Write(number_in + ", ");

            if (number_in > max)
            {
                max = number_in;
            }

            average = addition / index;

        }

        Console.WriteLine();
        Console.WriteLine("The sum of the list of numbers is " + addition + ".");
        Console.WriteLine("The average of the list of numbers is " + average + ".");
        Console.WriteLine("The largest number in the list is " + max + ".");
    }
}