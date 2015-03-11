using System;

class Test
{
    static void Main()
    {
        Triangle abc = new Triangle(6, 8, 12);
        Circle circle1 = new Circle(6);
        Rectangle rect1 = new Rectangle(3, 4);

        IShape[] shapes = new IShape[] { abc, circle1, rect1 };

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.ToString() + " area: " + Math.Round(shape.CalculateArea(), 2) + " pts2");
            Console.WriteLine(shape.ToString() + " perimeter: " + Math.Round(shape.CalculatePerimeter(), 2) + " pts");
            Console.WriteLine();
        }
    }
}