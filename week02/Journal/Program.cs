using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); // https://learn.microsoft.com/es-es/dotnet/api/system.console.clear?view=net-10.0
        // Console.WriteLine("Hello World! This is the Journal Project..");

        Journal journal1 = new Journal();

        //load prompts
        Prompts prompt1 = new Prompts();
        // prompt1.DisplayAllPrompts();

        string prompt;
        DateTime theCurrentTime;
        string dateText;
        string timeText;

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
                timeText = theCurrentTime.ToShortTimeString();
                Entries entry1 = new Entries();

                Console.WriteLine("1. Write a entry.");
                Console.WriteLine("-----------------");
                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                entry1._entryText = Console.ReadLine();
                entry1._date = dateText;
                entry1._promptText = prompt;
                entry1._time = timeText;

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
                Console.WriteLine(" ");
                Console.Write("Filename:");
                string fileName = Console.ReadLine();

                Files file1 = new Files();
                journal1._entries.Clear();

                List<string> journal2 = file1.LoadFromFile(fileName);
                foreach (string file in journal2)
                {
                    // Console.WriteLine(file);
                    string[] parts = file.Split("¨¨");
                    // Console.WriteLine($"{parts[2]}/{parts[0]}/{parts[1]}");

                    Entries entry1 = new Entries();
                    entry1._entryText = parts[3];
                    entry1._date = parts[0];
                    entry1._time = parts[1];
                    entry1._promptText = parts[2];

                    journal1.AddEntry(entry1);
                }
                Console.WriteLine("File loaded! ");
                Console.WriteLine(" ");


            }
            else if (respond == 4)
            {
                Console.WriteLine("4. Save the journal to a file. ");
                Console.WriteLine("------------------------------");
                Console.Write("Filename:");
                string fileName = Console.ReadLine();
                Files file1 = new Files();
                file1.SaveToFile(journal1._entries, fileName);
            }
            else
            {
                Console.WriteLine("Thanks for using our program. Bye!");
                Console.WriteLine(" ");
            }
        } while (respond != 5);

    }
}