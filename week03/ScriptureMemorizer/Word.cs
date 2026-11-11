public class Word
{
    private List<string> _word = new();
    private List<string> _state = new();
    public Word()
    {
        _word.Add("word");
        _state.Add("show");
    }
    public Word(string text)
    {
        //split the text in parts, separator: space
        string[] parts = text.Split(" ");
        _word.Clear();
        _state.Clear();
        foreach (string word in parts)
        {
            Console.WriteLine($"- {word}");
            _word.Add(word);
            _state.Add("show");
        }
    }

    public void WordHiding(int index)
    {
        _state[index] = "hide";
    }
}