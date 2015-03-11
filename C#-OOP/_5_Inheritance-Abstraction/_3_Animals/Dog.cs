using System;

public class Dog : Animal
{
    public Dog(string name, double age) : base(name, "male", age) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Djaf djaf! Dog");
    }
}
