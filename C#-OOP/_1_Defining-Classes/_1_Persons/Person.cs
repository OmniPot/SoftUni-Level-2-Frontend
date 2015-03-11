using System;
class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age) : this(name, age, null) { }
    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Name cannot be empty!");
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1 || value > 100)
                throw new ArgumentOutOfRangeException("Age must be in the range [1...100]!");
            this.age = value;
        }
    }

    public string Email
    {
        get { return this.name; }
        set
        {
            if (value == String.Empty)
                throw new ArgumentNullException("Email cannot be empty string!");
            if (value != null && !value.Contains("@"))
                throw new ArgumentException("Email must contain '@'!");
            this.email = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Person, Name: {0}, Age: {1}, Email: {2}.", this.name, this.age, this.email);
    }
}

