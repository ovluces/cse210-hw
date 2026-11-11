using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string respond = "";
        do
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("                      Scripture Memorizer");
            Console.WriteLine("-----------------------------------------------------------------");

            Reference reference1 = new();
            Console.WriteLine($"Reference: {reference1.GetReference(0)}");

            reference1 = new("Libro", 99, 4);
            Console.WriteLine($"Reference: {reference1.GetReference(0)}");

            reference1 = new("Libro2", 199, 4, 6);
            Console.WriteLine($"Reference: {reference1.GetReference(0)}");

            Scripture scripture1 = new();
            Console.WriteLine($"Scripture: {scripture1.ScriptureDisplay()}");

            scripture1 = new("libro", 1, 2, "texto de la escritura");
            Console.WriteLine($"Scripture: {scripture1.ScriptureDisplay()}");

            scripture1 = new("libro2", 221, 2222, 2233, "texto de la escritura 222");
            Console.WriteLine($"Scripture: {scripture1.ScriptureDisplay()}");

            Word word1 = new("texto de la escritura 222");


            Console.Write("> ");
            respond = Console.ReadLine();
        } while (respond != "quit");
    }
}