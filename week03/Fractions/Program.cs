using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction: {fraction1}");
        Fraction fraction2 = new Fraction(6);
        Console.WriteLine($"Fraction: {fraction2}");
        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine($"Fraction: {fraction3}");

    }
}