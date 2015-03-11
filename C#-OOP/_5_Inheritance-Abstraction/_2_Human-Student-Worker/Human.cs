using System;

public abstract class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentException("First name cannot be null.");
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentException("Last name cannot be null.");
            }
            this.lastName = value;
        }
    }
}

