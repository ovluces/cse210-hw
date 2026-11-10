using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction fraction1 = new Fraction();
        fraction1.GetFractionString();
        fraction1.GetDecimalValue();
        Fraction fraction2 = new Fraction(6);
        fraction2.GetFractionString();
        fraction2.GetDecimalValue();
        Fraction fraction3 = new Fraction(6, 7);
        fraction3.GetFractionString();
        fraction3.GetDecimalValue();
        Fraction fraction4 = new Fraction(6, 0);
        fraction4.GetFractionString();
        fraction4.GetDecimalValue();
        Fraction fraction5 = new Fraction(1, 3);
        fraction5.GetFractionString();
        fraction5.GetDecimalValue();

        //respuesta del cse
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString2());
        Console.WriteLine(f4.GetDecimalValue2());

    }
}