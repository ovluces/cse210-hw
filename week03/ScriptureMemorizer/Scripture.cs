public class Scripture
{
    //Proverbs 3:5
    private Reference _reference = new();
    private string _scriptureText;

    public Scripture()
    {
        _reference.Reference();
        _scriptureText = "";
    }

    public void setScripture(string book, int chapter, int verse, string scriptureText)
    {
        _reference.SetReference(book, chapter, verse);
        _scriptureText = scriptureText;
    }

    public void setScripture(string book, int chapter, int verse, int finalVerse, string scriptureText)
    {
        _reference.SetReference(book, chapter, verse, finalVerse);
        _scriptureText = scriptureText;
    }

    public void ScriptureDisplay()
    {

    }


}