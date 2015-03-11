using System;

public class Start
{
    public static void Main()
    {
        GenericList<int> integerList = new GenericList<int>() { };
        integerList.Add(2);
        integerList.Add(5);
        integerList.Add(8);

        Type type = typeof(GenericList<int>);
        object[] allAttributes = type.GetCustomAttributes(false);

        foreach (var item in allAttributes)
        {
            if (item is VersionAttribute)
            {
                Console.WriteLine("Generic List current Version: {0}", item.ToString());
            }
        }
    }
}
