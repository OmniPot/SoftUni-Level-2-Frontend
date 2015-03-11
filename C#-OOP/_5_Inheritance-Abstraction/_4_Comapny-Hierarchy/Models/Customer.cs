using System;

public class Customer : Person, ICustomer
{
    private decimal netPurchaseAmount;

    public Customer(int id, string firstName, string lastName, decimal netPurchaseAmount)
        : base(id, firstName, lastName)
    {
        this.NetPurchaseAmount = netPurchaseAmount;
    }

    public decimal NetPurchaseAmount
    {
        get { return this.netPurchaseAmount; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Customer net purchase ammount cannot be negative number.");
            }
            this.netPurchaseAmount = value;
        }
    }

    public override string ToString()
    {
        return string.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nPurchased: {3}",
           this.Id, this.FirstName, this.LastName, this.NetPurchaseAmount);
    }
}

