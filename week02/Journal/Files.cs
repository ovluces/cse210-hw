using System.IO;
public class Files
{
  public void SaveToFile(List<Entries> entries, string fileName)
  {
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      foreach (Entries entry in entries)
      {
        outputFile.WriteLine($"{entry._date}¨¨{entry._time}¨¨{entry._promptText}¨¨{entry._entryText}");
      }
    }
    Console.WriteLine("File saved!");
    Console.WriteLine(" ");
  }

  public List<string> LoadFromFile(string fileName)
  {
    Console.WriteLine($"Loading from: {fileName}");
    List<string> listOfLines = new List<string>();
    string[] lines = System.IO.File.ReadAllLines(fileName);
    foreach (string line in lines)
    {
      // Console.WriteLine($"line: {line}");
      listOfLines.Add(line);
    }
    Console.WriteLine(" ");
    return listOfLines;
  }
}