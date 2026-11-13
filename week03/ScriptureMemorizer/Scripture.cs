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
        // journal1._entries.Clear();
        string fileName = "scriptures.txt";
        int index = 0;
        List<string> listOfScriptures = LoadFromFile(fileName);
        foreach (string file in listOfScriptures)
        {
            // Console.WriteLine(file);
            string[] parts = file.Split("¨¨");
            // Console.WriteLine($"{parts[0]}/{parts[1]}/{parts[2]}");
            //parts[0] = book
            //parts[1] = Refenrence
            //parts[2] = scripture text

            string[] referenceParts = parts[1].Split(":");
            //chapter = referenceParts[0];
            int verse = 0;
            int finalVerse = 0;
            // Console.WriteLine($"Chapter: {referenceParts[0]}");
            //search for the "-" symbol, if exists then there are more than 1 verses
            if (referenceParts[1].Contains('-'))
            {
                // Console.WriteLine($"The reference contains -: {referenceParts[1]}");
                string[] verseParts = referenceParts[1].Split('-');
                // verseParts[0] = Initial Verse
                // verseParts[1] = Final Verse
                verse = int.Parse(verseParts[0]);
                finalVerse = int.Parse(verseParts[1]);
            }
            else
            {
                verse = int.Parse(referenceParts[1]);
                finalVerse = int.Parse(referenceParts[1]);
            }

            _reference.AddReference(parts[0], int.Parse(referenceParts[0]), verse, finalVerse);
            // Console.WriteLine($"Referencia: {_reference.GetReference(index)}");

            _scriptureText = new(parts[2]);
            // Console.WriteLine($"texto: {_scriptureText.DisplayText()}");

            index++;
        }
        // Console.WriteLine("File loaded! ");
        // Console.WriteLine(" ");

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
        string scripture = _reference.GetReference(0) + " " + _scriptureText.DisplayText();
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