using System.ComponentModel;

public class Scripture
{
    //Proverbs 3:5
    private Reference _reference = new();
    private Word _scriptureText = new();


    // Scripture

    //     HideRandomWords(numberToHide : int) : void
    //     GetDisplayText() : string
    //     IsCompletelyHidden() : bool

    public Scripture()
    {
        string fileName = "scriptures.txt";
        string book = "";
        int chapter = 0;
        int verse = 0;
        int finalVerse = 0;

        List<string> listOfScriptures = LoadFromFile(fileName);

        string file = listOfScriptures[2];

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
        _scriptureText = new(parts[2]);

    }

    // public Scripture(string book, int chapter, int verse, string scriptureText)
    // {
    //     _reference = new(book, chapter, verse);
    //     Word _scriptureText = new();
    // }

    // public Scripture(string book, int chapter, int verse, int finalVerse, string scriptureText)
    // {
    //     _reference = new(book, chapter, verse, finalVerse);
    //     Word _scriptureText = new();
    // }

    public string ScriptureDisplay()
    {
        string scripture = _reference.GetReference() + ". " + _scriptureText.DisplayText();
        return scripture;
    }

    // public string GetScriptureText()
    // {
    //     return _scriptureText.DisplayText();
    // }

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