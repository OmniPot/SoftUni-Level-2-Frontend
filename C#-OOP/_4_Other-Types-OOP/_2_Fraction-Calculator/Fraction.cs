using System;

public struct Fraction
{
    private long numerator;
    private long denominator;

    public Fraction(long numerator, long denominator)
        : this()
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    public long Numerator
    {
        get { return this.numerator; }
        set { this.numerator = value; }
    }

    public long Denominator
    {
        get 
        { 
            return this.denominator;
        }

        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Fraction denominator cannot be zero.");
            }

            this.denominator = value;
        }
    }

    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        return new Fraction((f1.Numerator * f2.Denominator) + (f1.Denominator * f2.Numerator), f1.Denominator * f2.Denominator);
    }

    public static Fraction operator -(Fraction f1, Fraction f2)
    {
        return new Fraction((f1.Numerator * f2.Denominator) - (f1.Denominator * f2.Numerator), f1.Denominator * f2.Denominator);
    }

    public override string ToString()
    {
        return ((decimal)this.numerator / (decimal)this.denominator).ToString();
    }
}
