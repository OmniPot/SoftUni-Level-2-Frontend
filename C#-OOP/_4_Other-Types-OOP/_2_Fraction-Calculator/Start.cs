using System;

public class Start
{
    public static void Main()
    {
        try
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 3);

            Fraction resultOfSum = fraction1 + fraction2;
            Fraction resultOfSubstraction = fraction1 - fraction2;

            Console.WriteLine(string.Format(resultOfSum.Numerator + "\\" + resultOfSum.Denominator));
            Console.WriteLine(resultOfSum);

            Console.WriteLine();

            Console.WriteLine(string.Format(resultOfSubstraction.Numerator + "\\" + resultOfSubstraction.Denominator));
            Console.WriteLine(resultOfSubstraction);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}