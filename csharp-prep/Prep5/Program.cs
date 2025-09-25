/*
DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born.
 The out parameter is set to their birth year. This function does not return a value. The user's birth year 
 is given back from the function via the out parameter.
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's 
name and squared number. Calculate hold many years old they will turn this year and display that.
Your Main function should then call each of these functions saving the return values and passing data to them as necessary.

Sample output of the program could look as follows:


Welcome to the program!
Please enter your name: Brother Burton
Please enter your favorite number: 42
Please enter the year you were born: 1990
Brother Burton, the square of your number is 1764
Brother Burton, you will turn 35 this year.
*/
using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //DisplayWelcome - Displays the message, "Welcome to the Program!"
        DisplayWelcome();

        //PromptUserName - Asks for and returns the user's name (as a string)
        string user_name = PromptUserName();

        //PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        int fav_number = PromptUserNumber();

        /*PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born.
         The out parameter is set to their birth year. This function does not return a value. The user's birth year 
         is given back from the function via the out parameter.*/
        //int birth_year = PromtUserBirthYear();
        int birth_year;
        PromtUserBirthYear(out birth_year);

        //SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        int squares = SquareNumber(fav_number);

        /*DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's 
        name and squared number. Calculate hold many years old they will turn this year and display that.
        Your Main function should then call each of these functions saving the return values and passing data to them as necessary.*/
        DisplayResult(squares, birth_year, user_name);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite whole number? ");
            int favorite_number = int.Parse(Console.ReadLine());
            return favorite_number;
        }

        static string PromptUserName()
        {
            Console.Write("What is your User Name? ");
            string name = Console.ReadLine();
            //dont forget to return on strings also
            return name;
        }

        //since I don't know what this should be, will a void work?
        //forgot to out

        static void PromtUserBirthYear(out int birth_year)
        {
            Console.Write("In which year where you born? ");
            birth_year = int.Parse(Console.ReadLine());
            //int age_now = 2025 - birth_year;
           // return age_now;
        }

        // dont add ; add the end of things like line 82, because then we spend too mauch time trying to figure out where we went wrong
        static int SquareNumber(int favorite_number)
        {
            int squares = favorite_number * favorite_number;
            return squares;

        }

        /*
        Brother Burton, the square of your number is 1764
        Brother Burton, you will turn 35 this year.
        */
        //static void DisplayResult(squares, birth_year, user_name)
        static void DisplayResult(int squares, int birth_year, string user_name)
        {
            int age_now = 2025 - birth_year;
            Console.WriteLine($"{user_name}, the square of your number is {squares}.");
            Console.WriteLine($"{user_name},  you will turn {age_now} this year.");

        }
    }
}