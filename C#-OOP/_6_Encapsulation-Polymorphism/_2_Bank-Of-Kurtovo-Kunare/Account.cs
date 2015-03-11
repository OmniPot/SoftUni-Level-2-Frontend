using System;

public abstract class Account : IAccount
{
    private string customerName;
    private CustomerType customerType;
    private double balance;
    private double interestRate;

    public Account(string customerName, CustomerType customerType, double interestRate)
    {
        this.CustomerName = customerName;
        this.CustomerType = customerType;
        this.InterestRate = interestRate;
    }

    public string CustomerName
    {
        get { return this.customerName; }
        set
        {
            if (value.Trim() == string.Empty && string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Account customer cannot be empty.");
            }
            this.customerName = value;
        }
    }

    public CustomerType CustomerType
    {
        get { return this.customerType; }
        private set { this.customerType = value; }
    }

    public double Balance
    {
        get { return this.balance; }
        protected set { this.balance = value; }
    }

    public double InterestRate
    {
        get { return this.interestRate; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Account interest rate cannot be negative.");
            }
            this.interestRate = value;
        }
    }

    public virtual double CalculateInterest(int months)
    {
        double interest = 0;
        interest = this.Balance - this.Balance * (1 + ((this.InterestRate / 100) * months));
        return Math.Abs(interest);
    }
}