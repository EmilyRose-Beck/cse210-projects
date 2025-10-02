using System;

//everything has to be public from what was said in class
//didn't work as just public Job
public class Job
{
    public string _title;
    public string _company;
    public int _firstYear;
    public int _endYear;


    public void Display()
    {
        Console.WriteLine($"{_title} ({_company}) {_firstYear} - {_endYear}");
    }

}

//I defenatly was over complation things when I was working without the guide.
//I don't know what I was doing but it wasn't this