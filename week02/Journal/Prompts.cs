public class Prompts
{
  static string promptFileName = "Prompts.txt";
  public List<string> _prompts = GetList();

  public string GetRandomPrompt()
  {
    int numberOfPrompts = _prompts.Count(); //obtain number of prompts in list
    Random randomGenerator = new Random();
    int randomPromptIndex = randomGenerator.Next(0, numberOfPrompts); //obtain a random index, between 0 and the count os prompts in list.
    string randomPrompt = _prompts[randomPromptIndex];
    return randomPrompt;
  }

  static List<string> GetList()
  {
    Files file1 = new Files();
    List<string> promptLines = file1.LoadFromFile(promptFileName);
    return promptLines;
  }

  public void DisplayAllPrompts()
  {
    int numberOfPrompts = _prompts.Count();
    Console.WriteLine($"Prompts (0 - {numberOfPrompts - 1}):");
    foreach (string prompt in _prompts)
    {
      Console.WriteLine($"- {prompt}");
    }
  }
}