using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction 1: no-arg constructor -> 1/1
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue().ToString(System.Globalization.CultureInfo.InvariantCulture));

        // Fraction 5: one-arg constructor -> 5/1
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue().ToString(System.Globalization.CultureInfo.InvariantCulture));

        // Fraction 3/4: two-arg constructor
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue().ToString(System.Globalization.CultureInfo.InvariantCulture));

        // Fraction 1/3: two-arg constructor
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue().ToString(System.Globalization.CultureInfo.InvariantCulture));
    }
}