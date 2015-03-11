using System;

class Start
{
    static void Main()
    {
        Point3D p1 = new Point3D(-7, -4, 3);
        Point3D p2 = new Point3D(17, 6, 2.5);

        double distance = DistanceClaculator.ClaculateDistance(p1, p2);

        Console.WriteLine("Distance between:\n" + p1.ToString() + "\n" + p2.ToString() + "\n= " + distance);
    }
}

