using System;

public class Sale : ISale
{
    private string productName;
    private DateTime date;
    private double price;

    public Sale(string productName, DateTime date, double price)
    {
        this.ProductName = productName;
        this.Date = date;
        this.Price = price;
    }

    public string ProductName
    {
        get { return this.productName; }
        set
        {
            if (String.IsNullOrEmpty(value) || value.Trim() == "")
            {
                throw new ArgumentNullException("Sale name cannot be null or empty.");
            }
            this.productName = value;
        }
    }

    public DateTime Date
    {
        get { return this.date; }
        set { this.date = value; }
    }

    public double Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Sale price cannot be negative number.");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Sale name: {0}\nSale date: {1}\nPrice: {2} lv.",
           this.ProductName, this.Date, this.Price);
    }
}