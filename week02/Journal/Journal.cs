public class Journal
{
  public List<Entries> _entries = new List<Entries>();

  public void AddEntry(Entries newEntry)
  {
    if (_entries == null)
    {
      Console.WriteLine("null? ");
    }
    else
    {
      _entries.Add(newEntry);
      // Console.WriteLine("added... ");
    }

  }

  public void DisplayAll()
  {
    // Console.WriteLine("Journal Entries: ");
    foreach (Entries entry in _entries)
    {
      entry.DisplayEntry();
    }
    Console.WriteLine(" ");
  }

}