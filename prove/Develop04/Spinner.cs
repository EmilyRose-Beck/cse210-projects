using System;
using System.Collections.Generic;
using System.Threading;

class Spinner
{
    private List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };

    public void Display(int seconds)
    {
        int i = 0;
        int totalFrames = seconds * 5;

        for (int frame = 0; frame < totalFrames; frame++)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
         }
}
