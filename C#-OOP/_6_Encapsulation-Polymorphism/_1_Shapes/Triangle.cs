using System;

public class Triangle : BasicShape
{
    private double sideC;

    public Triangle(double sideA, double sideB, double sideC)
        : base(sideA, sideB)
    {
        this.SideC = sideC;
    }

    public double SideC
    {
        get { return this.sideC; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Shape side cannot be negative.");
            }
            this.sideC = value;
        }
    }

    public override double CalculatePerimeter()
    {
        return this.SideA + this.SideB + this.SideC;
    }

    public override double CalculateArea()
    {
        double a = this.SideA;
        double b = this.SideB;
        double c = this.SideC;
        double halfP = this.CalculatePerimeter() / 2;

        return Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
    }
}
