public class Word
{
    private List<string> _word = new();
    private List<bool> _state = new();

    // Word
    // Hide() : void
    // Show() : void
    // IsHidden() : bool
    // GetDisplayText() : string

    public Word()
    {
        // _word.Add("word");
        // _state.Add(true);
    }
    public Word(string text)
    {
        //split the text in parts, separator: space
        string[] parts = text.Split(" ");
        _word.Clear();
        _state.Clear();
        foreach (string word in parts)
        {
            // Console.WriteLine($"- {word}");
            _word.Add(word);
            _state.Add(true);
        }
    }

    public void WordHiding(int index)
    {
        _state[index] = false;
    }

    public string DisplayText()
    {
        string texto = "";
        foreach (string word in _word)
        {
            // Console.WriteLine($"- {word}");
            texto = texto + word + ".";
        }
        return texto;
    }
}