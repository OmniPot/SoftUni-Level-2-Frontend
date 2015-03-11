using System;

public class Start
{
    public static void Main()
    {
        GenericList<int> listInt = new GenericList<int>();
        GenericList<string> listStr = new GenericList<string>();
        GenericList<bool> listBool = new GenericList<bool>();

        listBool.Add(true);
        listBool.Add(false);

        listInt.Add(15);
        listInt.Add(30);

        listStr.Add("sashooo");
        listStr.Add("angel");

        Console.WriteLine(listInt.Min());
        Console.WriteLine(listInt.Max());

        Console.WriteLine(listStr.Min());
        Console.WriteLine(listStr.Max());

        Console.WriteLine(listBool.Min());
        Console.WriteLine(listBool.Max());
    }
}
