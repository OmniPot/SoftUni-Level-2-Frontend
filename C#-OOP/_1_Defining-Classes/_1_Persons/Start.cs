using System;

class Start
{
    static void Main()
    {
        //Everything filled out.
        Person p = new Person("Rumen",20, "r.conkov@gmail.com");
        Console.WriteLine(p.ToString());

        //Email is null. Using the second constructor.
        Person p1 = new Person("Georgi", 25);
        Console.WriteLine(p1.ToString());

        //Throws Exception because email is an empty string.
        Person p2 = new Person("Georgi", 25, "");
        Console.WriteLine(p2.ToString());
    }
}
