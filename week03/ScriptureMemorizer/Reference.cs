public class Reference
{
    private List<string> _book = new();
    private List<int> _chapter = new();
    private List<int> _verse = new();
    private List<int> _finalVerse = new();

    public Reference()
    {

        _book.Add("Proverbs");
        _chapter.Add(3);
        _verse.Add(5);
        _finalVerse.Add(6);
    }

    public void SetReference(string book, int chapter, int verse)
    {
        _book[0] = book;
        _chapter[0] = chapter;
        _verse[0] = verse;
        _finalVerse[0] = 6;
    }

    public void SetReference(string book, int chapter, int verse, int finalVerse)
    {
        _book[0] = book;
        _chapter[0] = chapter;
        _verse[0] = verse;
        _finalVerse[0] = finalVerse;
    }

    public double GetReference(int index)
    {
        string fullReference = _book[index] + " " + _chapter[index].ToString + ": " + _verse[index].ToString + " - " + _finalVerse[index].ToString;
        return fullReference;
    }

}