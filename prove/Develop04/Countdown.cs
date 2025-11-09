/*
The C# language has a powerful Date and Time library. You might find it useful to get the current time, add a number of seconds to it, and then check if the current time is less than the new time.

This can be accomplished with the DateTime class. An object with the current time can be obtained withe DateTime.Now . Then, it has methods such as .AddSeconds(numberOfSeconds), and it works with the less than < operator as you would expect.

The following code snippet shows an example:
In the demo video, you can see the program pausing for a certain period of time. This can be done with the Thread.Sleep() method which takes an integer as the number of milliseconds for the current "thread of execution" to sleep or pause.

The following example shows how to make the computer to wait for 1 second (1000 milliseconds):


Console.WriteLine("Going to sleep for a second...");

Thread.Sleep(1000);

Console.WriteLine("I'm back!!");



DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(5);

Thread.Sleep(3000);

DateTime currentTime = DateTime.Now;
if (currentTime < futureTime)
{
    Console.WriteLine("We have not arrived at our future time yet...")
}
*/

using System;
using System.Globalization;
using System.Threading;

class Countdown
{
    public static void RunCountDown(int seconds)
    {
        

        Console.WriteLine("");

        for (int i = seconds; i > 0; i--)
        {
            // \r returns the line to the beginnging while \b cleans up the remaining numbers
            // ex 100 -> 99  without \r it looks like 990 if i don't have enough \b
            //also have to have at least one \b or else it will still look like 990 instead of 99

            Console.Write($"\r{i} \b");
            Thread.Sleep(1000);
        }
        Console.Write("\r   \r"); 
        //needs the second \b to replace the number at the end
        //Console.WriteLine($"\nAll done! You spent {seconds} seconds on this activity. ");
    }
}

//get timer input
/*public class Countdown
{
    {
        for (int )
    }
}
*/
