using System;

public abstract class Person : IDetailable
{
    private string name;
    private string details;

    public Person(string name, string details = null)        
    {
        this.Name = name;
        this.Details = details;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentException("Student name cannot be null or empty!");
            }
            this.name = value;
        }
    }
    public string Details
    {
        get { return this.details; }
        set
        {
            if (value.Trim() == "" && value != null)
            {
                throw new ArgumentException("Details cannot be empty string!");
            }
            this.details = value;
        }
    }
}

