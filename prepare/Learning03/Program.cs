using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Console.WriteLine(a.GetFractionString());

        Fraction b = new Fraction(6);
        Console.WriteLine(b.GetFractionString());

        Fraction c = new Fraction(6, 7);
        Console.WriteLine(c.GetFractionString());

        
    }
}