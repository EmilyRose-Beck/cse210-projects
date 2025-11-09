using System;
using System.Globalization;
using System.Threading;

class Countup
{

    public static void RunCountup(int seconds)
    {
        int number = 0;

        for (int i = 1; i <= seconds; i++)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1000);
            number = i;

        }
        Console.Write("\r   \r"); 
     }
}