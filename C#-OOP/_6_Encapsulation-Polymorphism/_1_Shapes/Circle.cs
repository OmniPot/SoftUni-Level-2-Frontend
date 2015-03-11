using System;

public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius
    {
        get { return this.radius; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Shape radius cannot be negative.");
            }
            this.radius = value;
        }
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }

    public double CalculateArea()
    {
        return Math.PI * (this.Radius * this.Radius);
    }
}