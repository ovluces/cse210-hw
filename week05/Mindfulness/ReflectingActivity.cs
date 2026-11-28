public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
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
        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(" ");
        DisplayPrompt();
        Console.WriteLine(" ");
        Console.Write("When you have something in mind, press enter to continue. ");
        string respuesta = Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine("Now ponder on each of the following questions as the related to this experience.");
        Console.WriteLine(" ");
        Console.Write("You may begin in: ");
        base.ShowCountDown(3);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                                    ");
        int seconds = base.GetDuration();
        int repetitions = (int)(seconds / 10);
        int timeEachQuestion = (int)(seconds / (repetitions + 1));

        GetRandomQuestion(); //randomize list

        for (int i = 0; i <= repetitions; i++)
        {
            DisplayQuestions(timeEachQuestion, i);
        }
    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _prompts.Count); //obtain a random index, between 0 and the count of prompts in list.
        return _prompts[randomIndex];
        // return $"{randomIndex} - {_prompts[randomIndex]}";
    }
    public void GetRandomQuestion()
    {
        //https://code-maze.com/csharp-randomize-list/
        for (int i = _questions.Count - 1; i > 0; i--)
        {
            int j = Random.Shared.Next(i + 1);
            (_questions[i], _questions[j]) = (_questions[j], _questions[i]);
        }
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
    public void DisplayQuestions(int time, int index)
    {
        Console.WriteLine(" ");
        Console.Write($"> {_questions[index]} ");
        base.ShowSpinner(time);
        Console.Write("\n");
    }

}