using System;
//biggest problem, I spent too much time doing this in python cause I'm dumb
class Program
{
    static void Main(string[] args)
    {
        Maths fractionOne = new Maths();
        Console.WriteLine(fractionOne.GetMathsString());
        Console.WriteLine(fractionOne.GetDecimal());

        Maths fractionTwo = new Maths(5);
        Console.WriteLine(fractionTwo.GetMathsString());
        Console.WriteLine(fractionTwo.GetDecimal());

        Maths fractionThree = new Maths(3, 4);
        Console.WriteLine(fractionThree.GetMathsString());
        Console.WriteLine(fractionThree.GetDecimal());


        Maths fractionFour = new Maths(1, 3);
        Console.WriteLine(fractionFour.GetMathsString());
        Console.WriteLine(fractionFour.GetDecimal());

    }
}