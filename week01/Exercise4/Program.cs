using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Series of numbers");
        Console.WriteLine("=================");
        List<int> numbersList = new List<int>();
        int userNumber = -1;
        do
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbersList.Add(userNumber);
            }
        } while (userNumber != 0);

        int sum = 0;
        foreach (int number in numbersList)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbersList.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbersList[0];

        foreach (int number in numbersList)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}