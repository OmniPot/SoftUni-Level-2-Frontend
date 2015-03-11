using System;

public class Frog : Animal
{
    public Frog(string name, string gender, double age) : base(name, gender, age) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Kwak! Frog");
    }
}
