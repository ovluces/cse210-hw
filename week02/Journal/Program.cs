using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); // https://learn.microsoft.com/es-es/dotnet/api/system.console.clear?view=net-10.0
        // Console.WriteLine("Hello World! This is the Journal Project..");

        Journal journal1 = new Journal();
        //journal1._entries = new List<Entries>();
        // List<Journal> journal1 = new List<Journal>();

        //load prompts
        Prompts prompt1 = new Prompts();
        // prompt1.DisplayAllPrompts();


        string prompt;
        DateTime theCurrentTime;
        string dateText;




        int respond = 0;

        //menu
        do
        {

            Console.WriteLine("Journal Programa - Welcome");
            Console.WriteLine("==========================");
            Console.WriteLine(" ");
            Console.WriteLine("Please write the number of the choice you want (1-5).");
            Console.WriteLine(" ");
            Console.WriteLine("1. Write a entry. ");
            Console.WriteLine("2. Display all entries. ");
            Console.WriteLine("3. Load a journal from a file. ");
            Console.WriteLine("4. Save the journal to a file. ");
            Console.WriteLine("5. Quit. ");
            Console.WriteLine(" ");
            Console.Write("> ");

            respond = int.Parse(Console.ReadLine());

            if (respond == 1)
            {
                prompt = prompt1.GetRandomPrompt();
                theCurrentTime = DateTime.Now;
                dateText = theCurrentTime.ToShortDateString();
                Entries entry1 = new Entries();

                Console.WriteLine("1. Write a entry.");
                Console.WriteLine("-----------------");
                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                entry1._entryText = Console.ReadLine();
                entry1._date = dateText;
                entry1._promptText = prompt;

                journal1.AddEntry(entry1);
                // entry1.DisplayEntry();
                Console.WriteLine(" ");


            }
            else if (respond == 2)
            {
                Console.WriteLine("2. Display all entries.");
                Console.WriteLine("-----------------------");
                journal1.DisplayAll();

            }
            else if (respond == 3)
            {
                Console.WriteLine("3. Load a journal from a file.");
                Console.WriteLine("------------------------------");
            }
            else if (respond == 4)
            {
                Console.WriteLine("4. Save the journal to a file. ");
                Console.WriteLine("------------------------------");
            }
            else
            {
                Console.WriteLine("Thanks for using our program. Bye!");
                Console.WriteLine(" ");
            }
        } while (respond != 5);

    }
}