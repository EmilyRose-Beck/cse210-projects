using System.ComponentModel.DataAnnotations;

class Word
{
    //attributes
    private string _word;
    private bool _revaeled;


    //behavoirs or contrutors
 
    public Word(string ____)
    {
        _word = ____;
        _revaeled = true;
    }

    public void Display()
    {
        if (_revaeled)
        {
            Console.Write(" " + _word);
        }
        else
        {
             Console.Write(" ");
            //Console.Write(" " + "____");
            int size = _word.Length;
            for (int i=0; i<size; i++)
            {
                Console.Write("_");

            }
        }

    }

    public void Hide()
    {
        _revaeled = false;
    }
    
    public bool IsRevealed()
    {
        return _revaeled;
    }
}