public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        int seconds = 0;
        Console.Clear();
        Console.WriteLine($"{_name} - Welcome");
        Console.WriteLine("=============================");
        Console.WriteLine(" ");
        Console.WriteLine($"{_description}");
        Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like for your session? (minimum 15 seconds - max 60 seconds) ");

        //https://stackoverflow.com/questions/4804968/how-can-i-validate-console-input-as-integers

        while (!int.TryParse(Console.ReadLine(), out seconds) || seconds < 15 || seconds > 60)
        {
            Console.Write("Invalid input. Please enter a number between 15 and 60: ");
        }
        _duration = seconds;

        Console.Clear();
        Console.WriteLine($"Get ready... ");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You hace completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> spinText = new List<string> { "|", "/", "-", "\\" };
        Console.CursorVisible = false; //https://learn.microsoft.com/en-us/dotnet/api/system.console.cursorvisible?view=net-11.0
        int i = 0;
        do
        {
            // Console.Write($"- {seconds}");
            Console.Write(spinText[i]);
            Thread.Sleep(100);
            Console.Write("\b \b");
            i++;
            if (i >= spinText.Count)
            {
                i = 0;
            }
        } while (DateTime.Now < endTime);
        Console.CursorVisible = true;
    }
    public void ShowCountDown(int seconds)
    {
        Console.CursorVisible = false; //https://learn.microsoft.com/en-us/dotnet/api/system.console.cursorvisible?view=net-11.0
        for (int i = seconds; i > 0; i--)
        {

            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Write("Ok");
        Console.CursorVisible = true;
    }


}