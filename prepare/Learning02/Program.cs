using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._title = "Software Engineer";
        job1._company = "Microsoft";
        job1._firstYear = 2019;
        job1._endYear = 2022;


        Job job2 = new Job();
        job2._title = "Nanny";
        job2._company = "Contractor";
        job2._firstYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._names = "John Doe";

        myResume._jobs.Add(job2);
        myResume._jobs.Add(job1);

        myResume.Display();
        //ok so it was only scary but I am still slighty confused by C#
        //not nessarly good but once I caught on it makes since now
    }
}