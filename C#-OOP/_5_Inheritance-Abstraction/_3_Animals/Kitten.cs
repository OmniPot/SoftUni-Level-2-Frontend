using System;

public class Kitten : Cat
{
    public Kitten(string name, double age) : base(name, "female", age) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Meaow! Kitten");
    }
}
