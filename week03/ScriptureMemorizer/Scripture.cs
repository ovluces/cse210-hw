public class Scripture
{
    //Proverbs 3:5
    private Reference _reference = new();
    private List<Word> _scriptureText = new();
    private List<int> _lastHiddenWords = new();
    private int _numberToHide = 3; //number of words to hide each Enter press

    public Scripture()
    {
        string fileName = "scriptures.txt";
        string book = "";
        int chapter = 0;
        int verse = 0;
        int finalVerse = 0;

        List<string> listOfScriptures = LoadFromFile(fileName);

        // obtain the index by randomize
        int numberOfScriptures = listOfScriptures.Count(); //obtain number of scriptures in list
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, numberOfScriptures); //obtain a random index, between 0 and the count of scriptures in list.

        string file = listOfScriptures[randomIndex];

        string[] parts = file.Split("¨¨");
        // Console.WriteLine($"{parts[0]}/{parts[1]}/{parts[2]}");
        book = parts[0];

        //parts[1] = Reference

        string[] referenceParts = parts[1].Split(":");
        chapter = int.Parse(referenceParts[0]);

        // Console.WriteLine($"Chapter: {referenceParts[0]}");
        //search for the "-" symbol, if exists then there are more than 1 verses
        //code from https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/strings/common-tasks/search
        if (referenceParts[1].Contains('-'))
        {
            string[] verseParts = referenceParts[1].Split('-');
            verse = int.Parse(verseParts[0]);
            finalVerse = int.Parse(verseParts[1]);
        }
        else
        {
            verse = int.Parse(referenceParts[1]);
            finalVerse = int.Parse(referenceParts[1]);
        }

        _reference = new(book, chapter, verse, finalVerse);

        //parts[2] = scripture text

        foreach (string word in parts[2].Split(' '))
        {
            _scriptureText.Add(new Word(word));
        }
    }


    public string ScriptureDisplay()
    {
        string texto = "";
        foreach (Word word in _scriptureText)
        {
            // Console.Write($"{word}*");
            texto = texto + " " + word.DisplayWord();
        }
        return _reference.GetReference() + ". " + texto;
    }

    public void HideRandomWords()
    {
        int numberOfWords = _scriptureText.Count(); //obtain number of prompts in list
        _lastHiddenWords.Clear();
        for (int i = 0; i < _numberToHide; i++)
        {
            bool change = true;
            do //generates random number of word until find a word to change
            {
                Random randomGenerator = new Random();
                int randomIndex = randomGenerator.Next(0, numberOfWords); //obtain a random index, between 0 and the count os prompts in list.
                change = _scriptureText[randomIndex].HideWord();
                if (change)
                {
                    _lastHiddenWords.Add(randomIndex);
                    // Console.WriteLine($"{_lastHiddenWords[i]}");
                }
                if (IsCompletelyHidden())
                {
                    break; //https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/statements/jump-statements
                }
            } while (!change); //do until change some value
        }
    }

    public void UndoRandomWords()
    {
        if (_lastHiddenWords.Count() > 0)
        // Console.WriteLine(_lastHiddenWords.Count());
        {
            for (int i = 0; i < _lastHiddenWords.Count(); i++)
            {
                // Console.WriteLine(i);
                _scriptureText[_lastHiddenWords[i]].ShowWord();
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        bool completelyHidden = true;
        foreach (Word word in _scriptureText)
        {
            if (word.GetState())
            {
                completelyHidden = false;
            }
        }
        return completelyHidden;
    }

    public List<string> LoadFromFile(string fileName)
    {
        fileName = "../../../" + fileName;
        string folder = AppDomain.CurrentDomain.BaseDirectory;
        string filePath = Path.Combine(folder, fileName);
        // Console.WriteLine($"Loading from: {filePath}");
        List<string> listOfLines = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            // Console.WriteLine($"line: {line}");
            listOfLines.Add(line);
        }
        // Console.WriteLine(" ");
        return listOfLines;
    }

}