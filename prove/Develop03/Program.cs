using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
       /* ScriptureList list = new ScriptureList();
        Reference randomScripture = list.GetRandomScripture();

        Console.WriteLine("Your random scripture is:");
        Console.WriteLine($"{randomScripture.GetDisplayText()} - {randomScripture.GetText()}");


        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
        */
        MangeScripture manager = new MangeScripture();
        manager.Run();

    }
}
