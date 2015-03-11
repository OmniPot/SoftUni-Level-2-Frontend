using System;

class Battery
{
    private string batModel;
    private double hours;

    public Battery(string model, double hours){
        this.Model = model;
        this.Hours = hours;
    }
    public Battery(string model) : this(model, 0) { }

    public string Model
    {
        get { return this.batModel; }
        set
        {
            if (value == String.Empty)
                throw new ArgumentNullException("Battery MODEL cannot be empty.");
            this.batModel = value;
        }
    }

    public double Hours
    {
        get { return this.hours; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Battery HOURS cannot be less than 0.");
            this.hours = value;
        }
    }
}

