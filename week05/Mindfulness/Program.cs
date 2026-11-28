class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");

        //Showing Creativity and Exceeding Requirements
        // Make sure no random questions are selected until they have all been used at least once in that session.

        //Data for the Activities


        List<string> ReflectingActivityPrompts = new();
        ReflectingActivityPrompts.Add("Think of a time when you stood up for someone else.");
        ReflectingActivityPrompts.Add("Think of a time when you did something really difficult.");
        ReflectingActivityPrompts.Add("Think of a time when you helped someone in need.");
        ReflectingActivityPrompts.Add("Think of a time when you did something truly selfless.");


        List<string> ReflectingActivityQuestions = new();
        ReflectingActivityQuestions.Add("Why was this experience meaningful to you?");
        ReflectingActivityQuestions.Add("Have you ever done anything like this before?");
        ReflectingActivityQuestions.Add("How did you get started?");
        ReflectingActivityQuestions.Add("How did you feel when it was complete?");
        ReflectingActivityQuestions.Add("What made this time different than other times when you were not as successful ?");
        ReflectingActivityQuestions.Add("What is your favorite thing about this experience?");
        ReflectingActivityQuestions.Add("What could you learn from this experience that applies to other situations?");
        ReflectingActivityQuestions.Add("What did you learn about yourself through this experience?");
        ReflectingActivityQuestions.Add("How can you keep this experience in mind in the future?");

        List<string> listingActivityPrompts = new();
        listingActivityPrompts.Add("Who are people that you appreciate?");
        listingActivityPrompts.Add("What are personal strengths of yours?");
        listingActivityPrompts.Add("Who are people that you have helped this week?");
        listingActivityPrompts.Add("When have you felt the Holy Ghost this month?");
        listingActivityPrompts.Add("Who are some of your personal heroes?");

        //menu
        string respond = "";
        do
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Project - Welcome");
            Console.WriteLine("=============================");
            Console.WriteLine(" ");
            Console.WriteLine("Menu Options. Write the number of the choice you want (1-4).");
            Console.WriteLine(" ");
            Console.WriteLine("1. Start breathing activity. ");
            Console.WriteLine("2. Start reflecting activity. ");
            Console.WriteLine("3. Start listing activity. ");
            Console.WriteLine("4. Quit. ");
            Console.WriteLine(" ");
            Console.Write("Select a choice from menu: ");

            respond = Console.ReadLine();

            if (respond == "1")
            {

                BreathingActivity myBreathingActivity = new("Breathing Activity", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.", 15);
                myBreathingActivity.DisplayStartingMessage();
                myBreathingActivity.Run();
                myBreathingActivity.DisplayEndingMessage();

            }
            else if (respond == "2")
            {
                ReflectingActivity myReflectingActivity = new("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 15, ReflectingActivityPrompts, ReflectingActivityQuestions);
                myReflectingActivity.DisplayStartingMessage();
                myReflectingActivity.Run();
                myReflectingActivity.DisplayEndingMessage();

            }
            else if (respond == "3")
            {
                ListingActivity myListingActivity = new("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 15, 0, listingActivityPrompts);
                myListingActivity.DisplayStartingMessage();
                myListingActivity.Run();
                myListingActivity.DisplayEndingMessage();
            }
            else
            {
                // Invalid menu option!
            }
        } while (respond != "4");
        Console.WriteLine("Bye!!");
        Console.WriteLine(" ");
    }

}