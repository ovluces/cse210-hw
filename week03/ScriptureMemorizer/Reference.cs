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

    public Reference(string book, int chapter, int verse)
    {
        _book.Add(book);
        _chapter.Add(chapter);
        _verse.Add(verse);
        _finalVerse.Add(0);
    }

    public Reference(string book, int chapter, int verse, int finalVerse)
    {
        _book.Add(book);
        _chapter.Add(chapter);
        _verse.Add(verse);
        _finalVerse.Add(finalVerse);
    }

    public string GetReference(int index)
    {
        // string fullReference = index.ToString();
        string fullReference = _book[index] + " " + _chapter[index].ToString() + ":" + _verse[index].ToString();
        if (_finalVerse[index] != 0)
        {
            fullReference = fullReference + "-" + _finalVerse[index].ToString();
        }

        return fullReference;
    }

}