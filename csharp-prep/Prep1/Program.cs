/*What is your first name? Scott
What is your last name? Burton

Your name is Burton, Scott Burton.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first name: ");
        string first_name = Console.ReadLine();
        string upper_first = first_name.ToUpper();

        Console.Write("Enter last name: ");
        string last_name = Console.ReadLine();
        string upper_last = last_name.ToUpper();
        
        Console.WriteLine("Your name is "+ upper_last + ", " + upper_first + " " + upper_last + ".");
    }
}