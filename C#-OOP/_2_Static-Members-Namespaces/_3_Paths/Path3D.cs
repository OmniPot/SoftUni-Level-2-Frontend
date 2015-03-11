using System;

class Path3D
{
    private Point3D[] points;

    public Path3D(params Point3D[] points)
    {
        this.points = points;
    }

    public Point3D[] Points
    {
        get { return this.points; }
    }
}

