using System;

class Point3D
{
    private int x;
    private int y;
    private int z;

    private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

    public Point3D(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public int X { get { return this.x; } }
    public int Y { get { return this.y; } }
    public int Z { get { return this.z; } }

    public static Point3D StartingPoint
    {
        get { return Point3D.startingPoint; }
    }

    public override string ToString()
    {
        return string.Format("X: {0}, Y: {1}, Z: {2}", this.x, this.y, this.z);
    }
}

