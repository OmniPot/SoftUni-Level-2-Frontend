using System;

public abstract class BasicShape : IShape
{
    private double sideA;
    private double sideB;

    public BasicShape(double sideA, double sideB)
    {
        this.SideA = sideA;
        this.SideB = sideB;
    }

    public double SideA
    {
        get { return this.sideA; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Shape side cannot be negative.");
            }
            this.sideA = value;
        }
    }

    public double SideB
    {
        get { return this.sideB; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Shape side cannot be negative.");
            }
            this.sideB = value;
        }
    }

    public abstract double CalculatePerimeter();

    public abstract double CalculateArea();

}