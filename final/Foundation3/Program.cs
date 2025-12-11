using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //fixed?
        RandomWeather randomWeather = new RandomWeather();
        string forecast = randomWeather.GetWeather();


        Address address1 = new Address("150 Esquire Dr", "Bells", "Tx");
        Address address2 = new Address("139 N 3rd E", "Rexburg", "ID");
        Address address3 = new Address("506 Lois St", "Aubrey", "Tx");

        Lecture lectureEvent = new Lecture("Dad's Lecture", "Dad found out someone forgot to lock the chicken coop.", "December 5th, 2015", "6:35 AM", address1, "Lecture", "Bring humiliaty", "Daniel Aaron Beck", 4);

        Reception receptionEvent = new Reception("Wedding Reception", "Oma wants to celebrate Tyler and Amber getting married", "November 16, 2025", "5:30pm", address2, "Family Reception", "Sunday Best or your nicest jeans", true);

        Reception receptionEvent2 = new Reception("Wedding Reception", "Oma wants to celebrate Tyler and Amber getting married", "November 16, 2025", "5:30pm", address2, "Family Reception", "Sunday Best or your nicest jeans", false);

        Outdoor outdoorEvent = new Outdoor("Childhood Home Tour", "Gonna look at the old house while remembering old memories, then play Ding Dong Ditch on the people now living there.", "Janurary 25, 2026", "1:00pm", address3, "Outdoor Activity","Wear running shoes", "Sunny", forecast);   

        //is this techinally polimorph? should i brake it down more?

        List<Event> events = new List<Event> {lectureEvent, receptionEvent, receptionEvent2, outdoorEvent};

        foreach (Event eventss in events)
        {
            Console.WriteLine("~~~~~~~~~~~~~~");

            Console.WriteLine("\n--- Standard ---");
            if (eventss is Lecture)
                Console.WriteLine(((Lecture)eventss).GetStandardDetails());
            else if (eventss is Reception)
                Console.WriteLine(((Reception)eventss).GetStandardDetails());
            else if (eventss is Outdoor)
                Console.WriteLine(((Outdoor)eventss).GetStandardDetails());
            else
                Console.WriteLine(eventss.GetStandardDetails());

            Console.WriteLine("\n--- Full ---");
            if (eventss is Lecture)
                Console.WriteLine(((Lecture)eventss).GetFullDetails());
            else if (eventss is Reception)
                Console.WriteLine(((Reception)eventss).GetFullDetails());
            else if (eventss is Outdoor)
                Console.WriteLine(((Outdoor)eventss).GetFullDetails());
            else
                Console.WriteLine(eventss.GetFullDetails());


            Console.WriteLine("\n--- Short ---");
            if (eventss is Lecture)
                Console.WriteLine(((Lecture)eventss).GetShortDetails());
            else if (eventss is Reception)
                Console.WriteLine(((Reception)eventss).GetShortDetails());
            else if (eventss is Outdoor)
                Console.WriteLine(((Outdoor)eventss).GetShortDetails());
            else
                Console.WriteLine(eventss.GetShortDetails());

            Console.WriteLine("~~~~~~~~~~~~~~");
    
        }

    }
}