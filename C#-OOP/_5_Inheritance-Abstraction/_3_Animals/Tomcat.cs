using System;

public class Tomcat : Cat
{
    public Tomcat(string name, double age) : base(name, "male", age) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Meaooowww! Tomcat");
    }
}
