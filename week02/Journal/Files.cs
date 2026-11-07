using System.IO;
public class Files
{
  public void SaveToFile(List<Entries> entries, string fileName)
  {
    string folder = AppDomain.CurrentDomain.BaseDirectory;
    string filePath = Path.Combine(folder, fileName);
    using (StreamWriter outputFile = new StreamWriter(filePath))
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

    string folder = AppDomain.CurrentDomain.BaseDirectory;
    string filePath = Path.Combine(folder, fileName);

    List<string> listOfLines = new List<string>();
    string[] lines = System.IO.File.ReadAllLines(filePath);
    foreach (string line in lines)
    {
      // Console.WriteLine($"line: {line}");
      listOfLines.Add(line);
    }
    Console.WriteLine(" ");
    return listOfLines;
  }
}