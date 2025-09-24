/*
Start by asking the user for the magic number. (In future steps, we will change this to have the computer generate a random number, but to get started, we'll just let the user decide what it is.)

Ask the user for a guess.

Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.

At this point, you won't have any loops.



Add a loop that keeps looping as long as the guess does not match the magic number.

At this point, the user should be able to keep playing until they get the correct answer.

The following shows the expected output at this point:



Instead of having the user supply the magic number, generate a random number from 1 to 100.

Play the game and make sure it works!
*/

using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        
        string try_again = " ";
        float number_of_guesses = 0;

        Console.WriteLine("Hello Welcome to Number Geuss!");

        /*Console.Write("Ask a friend to enter their number: ");
        string friends_number = Console.ReadLine();
        float correct_number = float.Parse(friends_number);*/

        Random random_generator = new Random();
        int number = random_generator.Next(0, 101);
        float correct_number = number;

        /*For testing random generator coding*/
        /*Console.WriteLine(correct_number);*/

        string comment = (" ");

        while (try_again.ToUpper() != "NO")
        {
            try_again = " ";
            number_of_guesses = number_of_guesses + 1;

            Console.Write("Guess the number: ");
            string guess = Console.ReadLine();
            float guessed_number = float.Parse(guess);


            if (guessed_number == correct_number)
            {
                comment = ("You got it!");
                try_again = ("NO");
            }

            else if (guessed_number > correct_number)
            {
                comment = ("Too high.");
            }


            else if (guessed_number < correct_number)
            {
                comment = ("Too low.");
            }
            else
            {
                comment = ("How?...");
            }

            Console.WriteLine(comment + " Number of attempts: " + number_of_guesses);
            
            while (try_again == " ")
            {
                Console.Write("Try again? ");
                string try_ag = Console.ReadLine();
                try_again = try_ag.ToUpper();
                
                if (try_again == "YES")
                {
                    Console.WriteLine("Let's try again!");
                }
                else if (try_again == "NO")
                {
                    Console.WriteLine("Bye bye!");
                }
                else
                {
                    Console.WriteLine("Sorry I didn't get that.");
                    try_again = " ";
                }
            }
        }

    }
}