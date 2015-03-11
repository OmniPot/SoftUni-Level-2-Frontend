using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

static class Storage
{
    public static Point3D[] LoadPath(string file)
    {
        using (StreamReader sr = new StreamReader(file))
        {
            string line;
            List<Point3D> points = new List<Point3D>();

            while ((line = sr.ReadLine()) != null)
            {
                double[] values = line.Split(',').Select(val => double.Parse(val)).ToArray();
                points.Add(new Point3D(values[0], values[1], values[2]));
            }
            sr.Close();
            return points.ToArray();
        }
    }

    public static void SavePath(string file, Path3D path)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (var point in path.Points)
            {
                sw.WriteLine(point.X + "," + point.Y + "," + point.Z);
            }
            sw.Close();
        }       
    }
}

