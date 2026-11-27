public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions new List<string>();
    public ReflectingActivity(List<string> prompts, List<string> questions, string name, string description, int duration) : base(name, description, duration)
    {

    }

    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    Run() : void
    GetRandomPrompt() : string
    GetRandomQuestion() : string
    DisplayPrompt() : void
    DisplayQuestions() : void

}