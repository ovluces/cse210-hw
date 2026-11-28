public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        //Constructor
    }

    public void Run()
    {
        int seconds = base.GetDuration();
        int repetitions = (int)(seconds - 5) / 10;  //the first cicle is 5 seconds, the next cicles are 10 seconds each

        Console.Clear();
        Console.Write("The activity will begin in... ");
        base.ShowCountDown(3);
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b                                                       ");
        Breathing(2, 3);

        for (int i = 0; i <= repetitions - 1; i++)
        {
            Breathing(4, 6);
        }
    }

    private void Breathing(int breatheIn, int breatheOut)
    {
        Console.WriteLine(" ");
        Console.Write("Breathe in... ");
        base.ShowCountDown(breatheIn);
        Console.WriteLine("");
        Console.Write("Now Breathe out... ");
        base.ShowCountDown(breatheOut);
        Console.WriteLine(" ");
    }


}