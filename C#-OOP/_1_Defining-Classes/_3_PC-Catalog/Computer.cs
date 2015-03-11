using System;
using System.Text;

class Computer
{
    private string name;
    private double price;
    private Component[] components;

    public Computer(string name, params Component[] components)
    {
        this.Name = name;
        this.components = components;
        this.Price = CalcTotalSum(this.components);
    }

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
        private set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Component price cannot be negative.");
            this.price = value;
        }
    }
    
    private double CalcTotalSum(Component[] components)
    {
        double totalSum = 0;
        for (int i = 0; i < components.Length; i++)
        {
            totalSum += components[i].Price;
        }
        return totalSum;
    }

    public override string ToString()
    {
        string name = "Name: " + this.name + "\n";
        string price = "Price: " + string.Format("{0:0.00}lv.\n", this.price);

        StringBuilder sb = new StringBuilder();
        sb.Append("Details:\n");
        for (int i = 0; i < components.Length; i++)
        {
            sb.Append(string.Format("{0} \\ {1} \\ {2:0.00}lv.\n", components[i].Name, components[i].Details, components[i].Price));
        }
        return name + price + sb.ToString();
    }
}

