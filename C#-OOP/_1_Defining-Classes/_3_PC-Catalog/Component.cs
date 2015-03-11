using System;

class Component
{
    private string name;
    private string details;
    private double price;

    public Component(string name, string details, double price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }

    public Component(string name, double price) : this(name, null, price) { }
    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentNullException("Component name cannot be empty.");
            this.name = value;
        }
    }

    public double Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Component price cannot be empty.");
            this.price = value;
        }
    }

    public string Details
    {
        get { return this.details; }
        set
        {
            if (value == String.Empty)
                throw new ArgumentNullException("Component Details cannot be empty.");
            this.details = value;
        }
    }

}

