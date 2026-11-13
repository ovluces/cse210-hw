public class Word
{
    private string _word;
    private bool _state;

    public Word()
    {
        _word = "word";
        _state = true;
    }
    public Word(string text)
    {
        _word = text;
        _state = true;
        // }
    }

    public bool HideWord()
    {
        if (_state)
        {
            _state = false;
            return true; //the value was changed
        }
        else
        {
            return false; //the value already was false
        }

    }

    public void ShowWord()
    {
        _state = true;
    }


    public bool GetState()
    {
        return _state;
    }

    public string DisplayWord()
    {
        string word = "";
        if (_state)
        {
            word = _word;
        }
        else
        {
            // int numberOfLetters = _word.Count();
            foreach (char letra in _word)
            {
                if ((letra == '.') || (letra == ',') || (letra == ';') || (letra == '—') || (letra == ',') || (letra == ':') || (letra == '!')) //omitting this characters for visualization
                {
                    word += letra;
                }
                else
                {
                    word += "_";
                }

            }
        }

        return word;
    }
}