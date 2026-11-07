using System.IO;
public class Files
{
  public void SaveToFile(string fileName)
  {

  }

  public List<string> LoadFromFile(string fileName)
  {
    List<string> ListOfLines = new List<string>();
    string[] lines = System.IO.File.ReadAllLines(fileName);
    foreach (string line in lines)
    {
      // Console.WriteLine($"line: {line}");
      ListOfLines.Add(line);
    }
    return ListOfLines;
  }
}