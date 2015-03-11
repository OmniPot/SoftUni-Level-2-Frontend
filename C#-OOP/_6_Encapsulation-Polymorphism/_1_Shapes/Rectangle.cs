using System;

public class Rectangle : BasicShape
{
    public Rectangle(double sideA, double sideB)
        : base(sideA, sideB) { }

    public override double CalculatePerimeter()
    {
        return 2 * (this.SideA + this.SideB);
    }

    public override double CalculateArea()
    {
        return this.SideA * this.SideB;
    }
}
