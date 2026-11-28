public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(" ");
        Console.WriteLine($"---- {GetRandomPrompt()} ----");
        Console.WriteLine(" ");
        Console.Write("You may begin in: ");
        base.ShowCountDown(3);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                                    \n");
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _prompts.Count); //obtain a random index, between 0 and the count of prompts in list.
        return _prompts[randomIndex];
    }
    public List<string> GetListFromUser()
    {
        List<string> lista = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        int i = 0;
        do
        {
            Console.Write("> ");
            lista.Add(Console.ReadLine());
            i++;
        } while (DateTime.Now < endTime);
        _count = lista.Count;
        return lista;
    }

}