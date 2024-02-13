public class Reference
{
    // private string _book;
    public string _book { get; set; }
    private int _chapter;
    private int _verse;

    Reference(string book, int chapter, int verse)
    {
    //     _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    Reference(string verse1, string verse2, string _book, int _chapter)
    {
        _wholeReference = _book + " " + _chapter + " " + verse1 + " " + verse2;
    }
    Reference(string verse1, string verse2, string verse3, string  _book, int _chapter)
    {
         = _book + " " + _chapter + " " + verse1 + " " + verse2 + " " + verse3;
    }


    public string GetReference()
    {
        return 
    }
}