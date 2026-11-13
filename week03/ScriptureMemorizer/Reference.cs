public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _finalVerse;


    // Reference

    //     GetDisplayText() : string
    //     Possible getters and setters

    public Reference()
    {
        _book = "Book";
        _chapter = 0;
        _verse = 0;
        _finalVerse = 0;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _finalVerse = verse;
    }

    public Reference(string book, int chapter, int verse, int finalVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _finalVerse = finalVerse;
    }

    public string GetReference()
    {
        string fullReference = _book + " " + _chapter.ToString() + ":" + _verse.ToString();
        if (_finalVerse != _verse)
        {
            fullReference = fullReference + "-" + _finalVerse.ToString();
        }
        return fullReference;
    }

}