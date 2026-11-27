public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity(int count, List<string> prompts, string name, string description, int duration) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }


    // public string GetStudentName()
    // {
    //     return _studentName;
    // }
    // public string GetSummary()
    // {
    //     return $"{_studentName} - {_topic}";
    // }

    public void Run()
    {

    }
    public string GetRandomPrompt()
    {
        return "";
    }
    public List<string> GetListFromUser()
    {
        return "";
    }

}