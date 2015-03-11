using System;

public abstract class Person : IPerson
{
    private int id;
    private string firstName;
    private string lastName;

    public Person(int id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public int Id
    {
        get { return this.id; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Person Id cannot be negative number.");
            }
            this.id = value;
        }
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (String.IsNullOrEmpty(value) || value.Trim() == "")
            {
                throw new ArgumentNullException("Person first name cannot be null or empty.");
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (String.IsNullOrEmpty(value) || value.Trim() == "")
            {
                throw new ArgumentNullException("Person last name cannot be null or empty.");
            }
            this.lastName = value;
        }
    }

    public abstract string ToString();
}

