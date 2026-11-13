using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string respond = ".";
        int index = 0;
        Console.Clear();
        Scripture scripture1 = new();
        do
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                            Scripture Memorizer");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            if (respond == "")
            {
                scripture1.HideRandomWords();
                Console.WriteLine($"{scripture1.ScriptureDisplay()}");
            }
            else if (respond == "undo")
            {
                // Console.WriteLine("Undo Last Words");
                scripture1.UndoRandomWords();
                Console.WriteLine($"{scripture1.ScriptureDisplay()}");
            }
            else
            {
                Console.WriteLine($"{scripture1.ScriptureDisplay()}");
            }
            Console.WriteLine("");
            Console.WriteLine("Press <Enter> for hide a few random words in the scripture.");
            Console.WriteLine("Type \"undo\" for undo the last words");
            Console.WriteLine("Type \"quit\" for finish");
            Console.WriteLine("");
            // Console.WriteLine(scripture1.IsCompletelyHidden());
            Console.Write("> ");
            respond = Console.ReadLine();
            if (respond == "" && scripture1.IsCompletelyHidden())
            {
                break;
            }
        } while (respond != "quit");
        Console.Write("Bye!");
    }
}