using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "No";
        do
        {


            // Console.WriteLine("Hello World! This is the Exercise3 Project.");

            // Console.Write("What is the magic number ? ");
            // string magicNumber = Console.ReadLine();
            Console.WriteLine("Guess My Number game");
            Console.WriteLine("====================");

            Random randomGenerator = new Random();
            int magicNumberInt = randomGenerator.Next(1, 101);

            // int magicNumberInt = int.Parse(magicNumber);
            int guessNumberInt;
            int numberOfGuess = 0;
            do
            {
                Console.Write("What is your guess? ");
                string guessNumber = Console.ReadLine();
                guessNumberInt = int.Parse(guessNumber);

                if (guessNumberInt < magicNumberInt)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumberInt > magicNumberInt)
                {
                    Console.WriteLine("Lower");
                }
                numberOfGuess++;

            } while (guessNumberInt != magicNumberInt);

            Console.WriteLine($"You guessed it! Took {numberOfGuess} intents!");

            Console.Write("Do you want to continue (yes / no)? ");
            response = Console.ReadLine();
        } while (response == "yes");


    }
}