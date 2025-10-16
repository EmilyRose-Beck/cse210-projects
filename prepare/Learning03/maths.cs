using System;
//don't forget to delete personal notes from comments
//should I change the name? Maths isn't a great name
public class Maths
{

    private int _numerator;
    private int _denominator;

    public Maths()
    {
        //sample uses 1 instead of 0 may need to change mine if 
        //I have problems with the code
        //i mattered
        _numerator = 1;
        _denominator = 1;

    }


    public Maths(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    //I forgot to do this and I just kept over looking it
    //while comparing to the sample
    public Maths(int num, int den)
    {
        _numerator = num;
        _denominator = den;
    }


    //I think this is a get?
    // its a get in the sample im not hopeless
    //I am dumb get is just part of the name
    //note: like sample name better change name to match
    // puts the fraction together
    public string GetMathsString()
    {
        string puttingItTogether = $"{_numerator}/{_denominator}";
        return puttingItTogether;

    }

    //naming things with Get in it seems important like how lists are tyopical pural
    public float GetDecimal()
    {
        return (float)_numerator / (float)_denominator;
    }

}