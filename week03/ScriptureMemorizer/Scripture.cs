public class Scripture
{
    //Proverbs 3:5
    private Reference _reference = new();
    private string _scriptureText;

    public Scripture()
    {
        _reference = new();
        _scriptureText = "text text text";

    }

    public Scripture(string book, int chapter, int verse, string scriptureText)
    {
        _reference = new(book, chapter, verse);
        _scriptureText = scriptureText;
    }

    public Scripture(string book, int chapter, int verse, int finalVerse, string scriptureText)
    {
        _reference = new(book, chapter, verse, finalVerse);
        _scriptureText = scriptureText;
    }

    public string ScriptureDisplay()
    {
        string scripture = _reference.GetReference(0) + " " + _scriptureText;

        return scripture;
    }


}