using System;

public abstract class Animal : ISound
{
    private string name;
    private string gender;
    private double age;

    public Animal(string name, string gender, double age)
    {
        this.Name = name;
        this.Gender = gender;
        this.Age = age;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be null.");
            }
            if (value.Trim() == "")
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            this.name = value;
        }
    }

    public string Gender
    {
        get { return this.gender; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Gender cannot be null.");
            }
            if (value.Trim() == "")
            {
                throw new ArgumentException("Gender cannot be empty.");
            }
            this.gender = value;
        }
    }

    public double Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || age > 50)
            {
                throw new ArgumentOutOfRangeException("Age cannot be negative.");
            }
            this.age = value;
        }
    }

    public abstract void ProduceSound();
}

