using System;

class Point3D
{
    private double x;
    private double y;
    private double z;

    private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

    public Point3D(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double X { get { return this.x; } }
    public double Y { get { return this.y; } }
    public double Z { get { return this.z; } }

    public static Point3D StartingPoint
    {
        get { return Point3D.startingPoint; }
    }

    public override string ToString()
    {
        return string.Format("X: {0}, Y: {1}, Z: {2}", this.x, this.y, this.z);
    }
}

