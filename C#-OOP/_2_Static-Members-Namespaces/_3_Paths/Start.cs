using System;

class Start
{
    static void Main()
    {
        //Write path to file.
        Path3D pathToWrite = new Path3D(
            new Point3D(1, 7, 3),
            new Point3D(6, 3, 1),
            new Point3D(9, 4, 5),
            new Point3D(2, 3, 4),
            new Point3D(7, 2, 5),
            new Point3D(5, 0, 2),
            new Point3D(9, 8, 3),
            new Point3D(2, 3, 9),
            new Point3D(1, 6, 2)
            );

        Storage.SavePath("TestFile.txt", pathToWrite);

        //Read path from file.
        Path3D loadedPath = new Path3D(Storage.LoadPath("TestFile.txt"));

        foreach (var p in loadedPath.Points)
        {
            Console.WriteLine(p);
        }
    }
}

